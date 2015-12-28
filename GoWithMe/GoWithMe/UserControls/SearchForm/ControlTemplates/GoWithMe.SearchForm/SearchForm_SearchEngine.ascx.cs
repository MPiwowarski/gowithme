using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoWithMe.SearchForm.Data;
using GoWithMe.SearchForm.View;
using System.Globalization;
using GoWithMe.Model.Extras;

namespace GoWithMe.SearchForm
{
    public partial class SearchEngine : System.Web.UI.UserControl, ISearchFormView
    {
        public event EventHandler LoadSearchEngine;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void InitSearchEngineComponents()
        {

        }

        public void ClearForm()
        {
            PlaceFromControl.Text = "";
            PlaceToControl.Text = "";
            rideDate.Text = "";
        }

        public SearchFormItem SearchData
        {
            get
            {
                if (Session["GetSearchDataVS"] != null)
                {
                    return Session["GetSearchDataVS"] as SearchFormItem;
                }
                else
                {
                    return new SearchFormItem();
                }
            }
            set
            {
                Session["GetSearchDataVS"] = value;
            }

        }


        public string PlaceFrom
        {
            get { return PlaceFromControl.Text; }
            set { PlaceFromControl.Text = value; }
        }

        public string PlaceTo
        {
            get { return PlaceToControl.Text; }
            set { PlaceToControl.Text = value; }
        }

        public DateTime? DateRide
        {
            get
            {
                if (rideDate.Text != "")
                {

                    IExtrasModel extrasModel = new ExtrasModel();

                    rideDate.Text = rideDate.Text.ToString().Replace('-', '/');
                    return extrasModel.AddDepartureHourToRideDate("00", "00", DateTime.ParseExact(rideDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                else
                {
                    return null;
                }
            }

        }

        public string DateRideCtrl
        {
            get
            {
                if (rideDate.Text != "")
                {
                    return Convert.ToDateTime(rideDate.Text).ToString("dd/MM/yyyy");
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (value != "")
                {
                    rideDate.Text = Convert.ToDateTime(value).ToString("dd/MM/yyyy");
                }
            }
        }

        protected void rideSearch_Load(object sender, EventArgs e)
        {
            if (LoadSearchEngine != null)
            {
                LoadSearchEngine(sender, e);
            }
        }

        public string SearchStatusControlText
        {
            get { return SearchStatusControl.Text; }
            set { SearchStatusControl.Text = value; }
        }

        public int PlaceFromWidth
        {
            get { return Convert.ToInt32(PlaceFromControl.Width); }
            set { PlaceFromControl.Width = value; }
        }
        public int PlaceToWidth
        {
            get { return Convert.ToInt32(PlaceToControl.Width); }
            set { PlaceToControl.Width = value; }
        }

        public bool SearchEngineFormValidate()
        {
            SearchStatusControl.ForeColor = System.Drawing.Color.Red;
            if (PlaceFrom == "")
            {
                SearchStatusControlText = "write start place";
                return false;
            }
            if (PlaceTo == "")
            {
                SearchStatusControlText = "write destination place";
                return false;
            }
            if (DateRide == null)
            {
                SearchStatusControlText = "write ride date";
                return false;
            }
            if (DateRide < DateTime.Now)
            {
                SearchStatusControlText = "wrong date";
                return false;
            }
            else
            {
                return true;
            }        
        }

        protected void SearchRideBtnControl_Click(object sender, EventArgs e)
        {
            if (SearchEngineFormValidate())
            {
                SearchFormItem searchFormItem = new SearchFormItem();
                searchFormItem.PlaceFrom = PlaceFrom;
                searchFormItem.PlaceTo = PlaceTo;
                searchFormItem.DateRide = DateRide;

                SearchData = searchFormItem;

                Response.Redirect("OffertsPanel.aspx");
            }

        }
    }


}