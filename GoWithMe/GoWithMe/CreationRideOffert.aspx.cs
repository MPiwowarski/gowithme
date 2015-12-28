using GoWithMe.Model.ModelDB;
using GoWithMe.Model.Repo;
using GoWithMe.Model.Extras;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// TODO: Sprawdzic czy uzytkownik jest zalogowany a jak nie to przekierowac go do strony glownej

namespace GoWithMe
{
    public partial class CreationRideOffert : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            if (userId == null)
            {
                Response.Redirect("Home.aspx");
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearForm();
            }
        }

        protected void AcceptBtnControl_Click(object sender, EventArgs e)
        {
            if (validationFormData())
            {
                saveFormDataToDb();
            }        
        }

        private bool validationFormData()
        {
            statusControl.ForeColor = System.Drawing.Color.Red;
            if(departureHourControl.Text == "")
            {
                statusControl.Text = "Departure hour is missing";
                return false;
            }
            else if ( departureMinutesControl.Text == "")
            {
                statusControl.Text = "Wrong number of minutes";
                return false;
            }

            if (Convert.ToInt32(departureHourControl.Text) > 23 || Convert.ToInt32(departureHourControl.Text) < 0)
            {
                statusControl.Text = "Wrong hour";
                return false;
            }
            else if (Convert.ToInt32(departureMinutesControl.Text) > 59 || Convert.ToInt32(departureMinutesControl.Text) < 0 || departureMinutesControl.Text=="")
            {
                statusControl.Text = "Wrong number of minutes";
                return false;
            }
            else if(dateRideControl.Text=="")
            {
                statusControl.Text = "Date of ride is missing";
                return false;
            }
            try
            {
                DateTime.ParseExact(dateRideControl.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(Exception ex)
            {
                statusControl.Text = "Date of ride is wrong";
            }

            if (fromRideControl.Text == "")
            {
                statusControl.Text = "Write start place";
                return false;
            }
            else if (toRideControl.Text == "")
            {
                statusControl.Text = "Write destination place";
                return false;
            }
            else if (cashToPayControl.Text == "")
            {
                statusControl.Text = "Write price for one sit";
                return false;
            }
            else if (Convert.ToInt32(cashToPayControl.Text) < 0)
            {
                statusControl.Text = "Wrong price for one sit";
                return false;
            }
            else if (offerRideDescriptionControl.Text == "")
            {
                statusControl.Text = "Write description";
                return false;
            }
            else if(numberOfSitsControl.Text=="")
            {
                statusControl.Text = "Write number of sits";
                return false;
            }
            else if(Convert.ToInt32(numberOfSitsControl.Text)<0)
            {
                statusControl.Text = "Wrong number of sits";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void saveFormDataToDb()
        {
            //Dodanie nowego uzytkownika
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            try
            {
                ITblOfferingRideRepository repo = new TblOfferingRideRepository();

                tblOfferingRide rideOffert = new tblOfferingRide();
                rideOffert.OffertDate = DateTime.Now;
                rideOffert.FromPlace = fromRideControl.Text;
                rideOffert.ToPlace = toRideControl.Text;

                IExtrasModel extrasModel = new ExtrasModel();
                rideOffert.RideDate = extrasModel.AddDepartureHourToRideDate(departureHourControl.Text, departureMinutesControl.Text, DateTime.ParseExact(dateRideControl.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
               

                rideOffert.Price = Convert.ToInt32(cashToPayControl.Text);
                rideOffert.CarModel = carModelControl.Text;
                rideOffert.OffertDescription = offerRideDescriptionControl.Text;
                rideOffert.tblUserId = (int)userId;
                rideOffert.NumberOfSits = Convert.ToInt32(numberOfSitsControl.Text);

                repo.AddNewRideOffert(rideOffert);
                ClearForm();
                statusControl.ForeColor = System.Drawing.Color.Green;
                statusControl.Text = "Ride offert was added successfully";

            }
            catch(Exception ex)
            {
                statusControl.ForeColor = System.Drawing.Color.Red;
                statusControl.Text = "Saving error";
            }
            
        }

        

        private void ClearForm()
        {
            fromRideControl.Text = "";
            toRideControl.Text = "";
            dateRideControl.Text = "";
            cashToPayControl.Text = "";
            carModelControl.Text = "";
            offerRideDescriptionControl.Text = "";
            departureHourControl.Text = "";
            departureMinutesControl.Text = "";
            numberOfSitsControl.Text = "";
        }


    }
}