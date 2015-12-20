using GoWithMe.SearchForm.View;
using GoWithMe.SearchForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoWithMe.View;
using GoWithMe.Model.Repo;

namespace GoWithMe
{
    public partial class OffertsPanel : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            InitializeSearchEngineVariables();
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            if (userId == null)
            {
                //Response.Redirect("Home.aspx");
            }
        }

        void InitializeSearchEngineVariables()
        {
            _searchFormView = (ISearchFormView)SearchForm_SearchEngine;
            _searchFormPresenter = new SearchFormPresenter(_searchFormView);

            var searchEngineItems = _searchFormPresenter.GetSearchData;
            _searchFormView.PlaceFrom = searchEngineItems.PlaceFrom;
            _searchFormView.PlaceTo = searchEngineItems.PlaceTo;
            _searchFormView.DateRideCtrl = searchEngineItems.DateRide.ToString();

            //PlaceFromControl.Text = SearchData.PlaceFrom;
            //PlaceToControl.Text = SearchData.PlaceTo;
            //rideDate.Text = SearchData.DateRide.ToString();

        }

        private SearchFormPresenter _searchFormPresenter;
        private ISearchFormView _searchFormView;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (_searchFormView.SearchEngineFormValidate())
            {
                ShowSearchEngineResults();
            }
           
        }




        private void ShowSearchEngineResults()
        {
            var searchEngineItems = _searchFormPresenter.GetSearchData;
            IDataRepository repo = new DataRepository();

            var result = repo.GetSearchEngineResult(searchEngineItems.PlaceFrom, searchEngineItems.PlaceTo, searchEngineItems.DateRide);

            //TODO;
            //1. Dopisac nazwy kolumn
            //2. Ostylować wszystko
            //3. Dopisac nr telefonu i description
            //4. Zoptymalizowac wyszukiwanie na zmniejszenie wszystkich wpisanych liter
            

            string html = "";
            html += "<table class=\"searchResultTable\">";
            

            foreach (var item in result)
            {
                html += "<tr>";

                //------------------------------- USERR DATA --------------------------------------------
                var img = item.Image;
                if (img != null)
                {
                    string base64String = Convert.ToBase64String(img, 0, img.Length);
                    html += "<td><ul class=\"userDataColumn\"> <li> <img src=\"data:image/png;base64," + base64String+ "\"/>" + "</li>";            
                }
                html += "<li>" + item.UserName + "</li>";
                html += "<li>"+ item.UserSurname + "</li></td>";

                //------------------------------- OFFERT DATA --------------------------------------------

                html += "<td><ul class=\"offertDataColumn\"> <li>" + item.RideDate + "</li>";
                html += "<li style=\"color:red; \">" + item.FromPlace + "</li>";
                html += "<li>" + item.ToPlace + "</li></td>";

                //------------------------ PRICE AND NUMBER OF SITS ---------------------------------------


                html += "</tr>";
            }
            html += "</table>";
            searchResult.InnerHtml = html;
        }
    }
}


//Image img = new Image();
//img.ImageUrl = "/scierwo.jpg";
//img.CssClass = "someclass";
//img.ID = "someid";
//img.AlternateText = "alttext";

//SearchResult.Controls.Add(img);
