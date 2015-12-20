using GoWithMe.Model.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe
{
    public partial class LoginPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtnControl_Click(object sender, EventArgs e)
        {
            ITblUserRepository repo = new TblUserRepository();
            if (repo.TryToLogIn(LoginTryControl.Text,PasswordTryControl.Text))
            {
                ResultTryLogin.ForeColor = System.Drawing.Color.Green;
                ResultTryLogin.Text = "Jesteś zalogowany";

                Session["UserId"]= (repo.GetUserByGivenLogin(LoginTryControl.Text).ID).ToString();
               
                Response.Redirect("UserPanel.aspx");
            }
            else
            {
                ResultTryLogin.ForeColor = System.Drawing.Color.Red;
                ResultTryLogin.Text = "Wprowadzone dane są nieprawidłowe";
            }

        }
    }
}