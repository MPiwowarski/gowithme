using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe.UserControls.MainMenu.ControlTemplates.GoWithMe.MainMenu
{
    public partial class MainMenu_Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            if (userId == null)
            {
                LogoutMenuItem.Visible = false;
                
                UserPanelMenuItem.Visible = false;

            }
            else
            {
                LoginMenuItem.Visible = false;
                ReigistrationControl.Visible = false;
            }


        }

        protected void LogoutMenuItem_Click(object sender, EventArgs e)
        {
            Session["UserId"] = null;
            Response.Redirect("Home.aspx");
        }

        
    }
}