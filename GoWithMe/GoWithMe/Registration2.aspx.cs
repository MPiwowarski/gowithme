using GoWithMe.Model.Repo;
using GoWithMe.Model.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoWithMe.View;

namespace GoWithMe
{
    public partial class Registration2 : System.Web.UI.Page, IRegistrationForm
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClearFormControl_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            emailControl.Text = "";
            loginControl.Text = "";
            passwordControl.Text = "";
            confirmPasswordControl.Text = "";

            nameControl.Text = "";
            surnameControl.Text = "";
            phoneNumberControl.Text = "";
        }

        protected void RegisterBtnControl_Click(object sender, EventArgs e)
        {
            ITblUserRepository repo = new TblUserRepository();
            if (Page.IsValid)
            {
                if (repo.SearchIfGivenLoginAlreadyExists(Login) == true)
                {
                    statusControl.Text = "Login o podanej nazwie już istnieje w bazie danych!";
                    statusControl.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    //Dodanie nowego uzytkownika
                    tblUser newUser = new tblUser();
                    newUser.Email = Email;
                    newUser.Login = Login;
                    newUser.Password = Password;
                    newUser.Name = Name;
                    newUser.Surname = Surname;
                    newUser.PhoneNumber = PhoneNumber;
                    newUser.RegistrationDate = RegistrationDate;
                    repo.AddNewUser(newUser);

                    ClearForm();

                    statusControl.Text = "Rejestracja zakończona pomyślnie!";
                    statusControl.ForeColor = System.Drawing.Color.Green;
                    //przekeirowanie do strony glownej
                    //Response.Redirect("Home.aspx");
                }
            }


        }

        #region IRegistrationForm implemenation
        public string Email
        {
            get { return emailControl.Text; }
        }

        public string Login
        {
            get { return loginControl.Text; }
        }

        public string Password
        {
            get { return passwordControl.Text; }
        }

        public string Name
        {
            get { return nameControl.Text; }
        }

        public string Surname
        {
            get { return surnameControl.Text; }
        }

        public string PhoneNumber
        {
            get { return phoneNumberControl.Text; }
        }

        public DateTime RegistrationDate
        {
            get { return DateTime.Now; }
        }
        #endregion


    }
}