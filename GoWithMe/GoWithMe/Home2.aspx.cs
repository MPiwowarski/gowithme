using GoWithMe.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe
{
    public partial class Home2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region IGlobalRideSearchEngine implementation
        public string PlaceFrom
        {
            get { return PlaceFromControl.Text; }
        }

        public string PlaceTo
        {
            get { return PlaceToControl.Text; }
        }

        public DateTime DateRide
        {
            get { return Convert.ToDateTime(rideDate.Text); }
        }
        #endregion



        protected void SearchRideBtnControl_Click(object sender, EventArgs e)
        {
            Session["PlaceFromGlobalRideSearch"] = PlaceFrom;
            Session["PlaceToGlobalRideSearch"] = PlaceTo;
            Session["DateRideGlobalRideSearch"] = DateRide;

        }
    }
}