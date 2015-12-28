using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoWithMe.View;
using GoWithMe.Model.ModelDB;
using GoWithMe.Model.Repo;

/*
sprawdzanie czy email jest unikatowy
haslo nie moze byc takie samo jak login
haslo nie moze byc za krotkie 6 znakow
login nie moze byc za krotki 6 znakow

*/
namespace GoWithMe
{
    public partial class Registration : System.Web.UI.Page, IRegistrationForm
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
            if (Page.IsValid)
            {
                ITblUserRepository repo = new TblUserRepository();
                if (repo.SearchIfGivenLoginAlreadyExists(Login))
                {
                    statusControl.Text = "Given login already exists in database!";
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

                    statusControl.Text = "Registration passed succedfully!";
                    statusControl.ForeColor = System.Drawing.Color.Green;
                    Response.AddHeader("REFRESH", "1;URL=LoginPanel.aspx");
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