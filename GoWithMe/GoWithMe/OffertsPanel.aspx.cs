using GoWithMe.SearchForm.View;
using GoWithMe.SearchForm.Presenter.DefaultPresenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoWithMe.View;
using GoWithMe.Model.Repo;
using GoWithMe.GWMExtras;
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

            var searchEngineItems = _searchFormPresenter.GetSearchData();
            _searchFormView.PlaceFrom = searchEngineItems.PlaceFrom;
            _searchFormView.PlaceTo = searchEngineItems.PlaceTo;
            _searchFormView.DateRideCtrl = searchEngineItems.DateRide.ToString();

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
            var searchEngineItems = _searchFormPresenter.GetSearchData();
            IDataRepository repo = new DataRepository();

            var result = repo.GetSearchEngineResult(searchEngineItems.PlaceFrom, searchEngineItems.PlaceTo, searchEngineItems.DateRide);

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
                    html += "<td><ul class=\"userDataCollumn\"> <li> <img class=\"offertUserImage\" src=\"data:image/png;base64," + base64String+ "\"/>" + "</li>";            
                }
                else
                {
                    html += "<td><ul class=\"userDataCollumn\"> <li> <img class=\"offertUserImage\" src=\"Images/UserPanel/UserPanelImage.png\" />" + "</li>";
                }
                html += "<td><ul class=\"userDataCollumn\"><li>" + item.UserName + "</li>";
                html += "<li>"+ item.UserSurname + "</li></ul></td>";
//C:\Users\Lenovo W520\Documents\Visual Studio 2015\Projects\GoWithMe\GoWithMe\Images\UserPanel\UserPanelImage.png
                //------------------------------- OFFERT DATA --------------------------------------------

                html += "<td><ul class=\"offertDataCollumn\"> <li>" + item.RideDate.ToString("dd-mm-yyyy")+ "</li>";
                html += "<li style=\"color:red; \">" + item.FromPlace + " --> " + item.ToPlace + "</li>";
                html += "<li> Car model:" + item.CarModel + "</li></td>";

                //------------------------ PHONE NUMEBR CONTACT -------------------------------------------
                html += "<td><ul class=\"phoneNumberCollumn\"> <li>" + "Contact phone:"  + "</li>";
                html += "<li>" + GwmExtras.ChangeNumberFormat(item.PhoneNumber) +  "</li></td>";

                //------------------------ DESCRIPTION ----------------------------------------------------
                html += "<td><ul> <li>" + "Offert description:" + "</li>";
                html += "<li class=\"descriptionCollumn\">" + item.Description + "</li></td>";

                //------------------------ PRICE AND NUMBER OF SITS ---------------------------------------
                html += "<td><ul> <li class=\"priceCollumn\">" + "Price: " + item.Price + " $ " + "</li>";
                html += "<li> Number of sits: " + item.NumberOfSits + "</li></td>";


                html += "</tr>";
            }
            html += "</table>";
            searchResult.InnerHtml = html;
        }

        
    }
}

