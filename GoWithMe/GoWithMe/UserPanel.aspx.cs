using GoWithMe.Model.ModelDB;
using GoWithMe.Model.Repo;
using GoWithMe.SearchForm.Presenter;
using GoWithMe.SearchForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//TODO: ukryc pole Zaloguj z menu, gdy użytkownik jest już zalogowany
//TODO: Zmienic ciastko na zmnienna sessionState
//TODO: Dorzucić przedrostki do identyfikatorów 
//TODO: Dorzucić szyfrowanie haseł w bazie danych
//TODO: Dorzucić walidacje danych po stronie serwera

namespace GoWithMe
{
    public partial class UserPanel : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            int? userId = Session["UserId"]!=null ? Convert.ToInt32(Session["UserId"]) : (int?)null;
            
            if (userId == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                setFieldsData();
            }
        }

    
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AcceptBtnControl_Click(object sender, EventArgs e)
        {

            int? userId = Session["UserId"]!=null ? Convert.ToInt32(Session["UserId"]) : (int?)null;
            ITblUserRepository repo = new TblUserRepository();
            if (Page.IsValid)
            {
                if (repo.SearchIfGivenLoginAlreadyExists(Login) == true && Login!= repo.GetUserById(Convert.ToInt32(userId)).Login && userId!=null)
                {
                    statusControl.Text = "Login o podanej nazwie już istnieje w bazie danych!";
                    statusControl.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    try
                    {
                        //Dodanie nowego uzytkownika
                        tblUser editUser = new tblUser();
                        editUser.ID = repo.GetUserById(Convert.ToInt32(userId)).ID;
                        editUser.Email = Email;
                        editUser.Login = Login;
                        editUser.Password = Password;
                        editUser.Name = Name;
                        editUser.Surname = Surname;
                        editUser.PhoneNumber = PhoneNumber;
                        editUser.RegistrationDate = RegistrationDate;
                        repo.UpdateUserData(editUser);

                        statusControl.Text = "Rejestracja zakończona pomyślnie!";
                        statusControl.ForeColor = System.Drawing.Color.Green;
                    }
                    catch(Exception ex)
                    {
                        statusControl.Text = "Nastąpił nieoczekiwany bład aplikacji";
                        statusControl.ForeColor = System.Drawing.Color.Red;
                    }
                    
                }
            }
        }

        private void setFieldsData()
        {
            int? userId = Session["UserId"]!=null ? Convert.ToInt32(Session["UserId"]) : (int?)null;
            ITblUserRepository repo = new TblUserRepository();
            if (userId != null)
            {
                tblUser user = repo.GetUserById(Convert.ToInt32(userId));

                emailControl.Text = user.Email;
                loginControl.Text = user.Login;

                nameControl.Text = user.Name;
                surnameControl.Text = user.Surname;
                phoneNumberControl.Text = user.PhoneNumber;
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