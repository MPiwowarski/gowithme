using GoWithMe.GWMExtras;
using GoWithMe.Model.Repo;
using GoWithMe.SearchForm.Presenter.DefaultPresenter;
using GoWithMe.SearchForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe
{
    public partial class MyOfferts : System.Web.UI.Page
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

            ShowUsersRideOfferts();

        }

        private void ShowUsersRideOfferts()
        {
            ListOfferts.Controls.Clear();
            int userId = Convert.ToInt32(Session["UserId"]);

            IDataRepository repo = new DataRepository();

            var result = repo.GetAllUsersRideOfferts(userId);
            UserRideOfferts = result;
            string html = "";
            if (result.Any())
            {
                #region htmlMethod
                //    html += "<table class=\"searchResultTable\">";


                //    foreach (var item in result)
                //    {
                //        html += "<tr>";

                //        //------------------------------- OFFERT DATA --------------------------------------------
                //        html += "<td>" +  "<input type=\"checkbox\" ID=\"" + "position" + item.OffertId +"\" runat=\"server\" >" + "</td>";

                //        html += "<td><ul class=\"offertDataCollumn\"> <li>" + item.RideDate.ToString("dd-mm-yyyy") + "</li>";
                //        html += "<li style=\"color:red; \">" + item.FromPlace + " --> " + item.ToPlace + "</li>";
                //        html += "<li> Car model:" + item.CarModel + "</li></td>";

                //        //------------------------ PHONE NUMEBR CONTACT -------------------------------------------
                //        html += "<td><ul class=\"phoneNumberCollumn\"> <li>" + "Contact phone:" + "</li>";
                //        html += "<li>" + GwmExtras.ChangeNumberFormat(item.PhoneNumber) + "</li></td>";

                //        //------------------------ DESCRIPTION ----------------------------------------------------
                //        html += "<td><ul> <li>" + "Offert description:" + "</li>";
                //        html += "<li class=\"descriptionCollumn\">" + item.Description + "</li></td>";

                //        //------------------------ PRICE AND NUMBER OF SITS ---------------------------------------
                //        html += "<td><ul> <li class=\"priceCollumn\">" + "Price: " + item.Price + " $ " + "</li>";
                //        html += "<li> Number of sits: " + item.NumberOfSits + "</li></td>";


                //        html += "</tr>";
                //    }
                //    html += "</table>";
                //}
                //ListOfferts.InnerHtml = html;
                #endregion
                List<CheckBox> tempAllCheckBoxes = new List<CheckBox>();

                Table table = new Table();
                foreach (var item in result)
                {
                    TableRow tr = new TableRow();
                    TableCell tdCheckBox = new TableCell();
                    TableCell tdOffertData = new TableCell();
                    TableCell tdContact = new TableCell();
                    TableCell tdDescription = new TableCell();
                    TableCell tdPriceAndNumberOfSits = new TableCell();

                    CheckBox checkBox_selected = new CheckBox();
                    checkBox_selected.ID = item.OffertId.ToString();
                    checkBox_selected.InputAttributes.Add("class", "dataCheckBox");

                    tr.Cells.Add(tdCheckBox);
                    tr.BackColor = System.Drawing.Color.White;

                    if (item.RideDate > DateTime.Now)
                    {
                        tdCheckBox.Controls.Add(checkBox_selected);
                        tempAllCheckBoxes.Add(checkBox_selected);
                        tr.BackColor = System.Drawing.Color.FromName("#a8f88d");
                    }

                    //------------------------------- OFFERT DATA --------------------------------------------
                    Label label_OffertData = new Label(); // { CssClass = "offertDataCollumn" };
                    label_OffertData.Text =
                    "<ul class=\"offertDataCollumn\"> <li>" + item.RideDate.ToString("dd-mm-yyyy") + "</li>" +
                    "<li style=\"color:red; \">" + item.FromPlace + " --> " + item.ToPlace + "</li>" +
                    "<li> Car model:" + item.CarModel + "</li></ul>";
                    tdOffertData.Controls.Add(label_OffertData);
                    tr.Cells.Add(tdOffertData);

                    //------------------------ PHONE NUMEBR CONTACT -------------------------------------------
                    Label label_Contact = new Label(); 
                    label_Contact.Text = "<ul class=\"phoneNumberCollumn\"> <li>" + "Contact phone:" + "</li>"+
                    "<li>" + GwmExtras.ChangeNumberFormat(item.PhoneNumber) + "</li></ul>";
                    tdContact.Controls.Add(label_Contact);
                    tr.Cells.Add(tdContact);

                    //------------------------ DESCRIPTION ----------------------------------------------------
                    Label label_Description = new Label();
                    label_Description.Text = 
                    "<ul><li>" + "Description:" + "</li>"+
                    "<li class=\"descriptionCollumn\">" + item.Description + "</li></ul>";
                    tdDescription.Controls.Add(label_Description);
                    tr.Cells.Add(tdDescription);

                    //------------------------ PRICE AND NUMBER OF SITS ---------------------------------------
                    Label label_PriceAndNumberOfSits = new Label();
                    label_PriceAndNumberOfSits.Text = "<ul> <li class=\"priceCollumn\">" + "Price: " + item.Price + " $ " + "</li>"+
                    "<li> Number of sits: " + item.NumberOfSits + "</li></ul>";
                    tdPriceAndNumberOfSits.Controls.Add(label_PriceAndNumberOfSits);
                    tr.Cells.Add(tdPriceAndNumberOfSits);

                    table.Rows.Add(tr);
                    ListOfferts.Controls.Add(table);                                     
                }
                AllOffertsCheckBoxes = tempAllCheckBoxes;

            }

        }

        public List<CheckBox> AllOffertsCheckBoxes
        {
            get
            {
                return Session["AllOffertsCheckBoxes"] as List<CheckBox>;
            }
            set
            {
                Session["AllOffertsCheckBoxes"] = value;
            }
        }


        public List<RidesOfferts> UserRideOfferts
        {
            get
            {
                return Session["UserRideOfferts"] as List<RidesOfferts>;
            }
            set
            {
                Session["UserRideOfferts"] = value;
            }
        }

        protected void DeleteSelectedControl_Click(object sender, EventArgs e)
        {
            List<CheckBox> updateAllCheckBoxes = new List<CheckBox>();
            List<CheckBox> itemsToDelete = new List<CheckBox>();
            foreach(var x in AllOffertsCheckBoxes)
            {
                if(!x.Checked)
                {
                    updateAllCheckBoxes.Add(x);
                }
                else
                {
                    itemsToDelete.Add(x);
                }
            }
            AllOffertsCheckBoxes = updateAllCheckBoxes;

            ITblOfferingRideRepository repo = new TblOfferingRideRepository();

           
            List<int> idsItemsToDelete = itemsToDelete.Select(x => x.ID.Replace("mainContent_","")).ToList().Select(int.Parse).ToList();
            repo.DeleteSelectedItems(idsItemsToDelete);

            ShowUsersRideOfferts();
        }


    }


}