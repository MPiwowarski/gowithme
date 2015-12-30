using GoWithMe.GWMExtras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace GoWithMe
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AcceptBtnControl_Click(object sender, EventArgs e)
        {
            if(FormValidation())
            {
                GwmExtras extras = new GwmExtras();

                string emailContent = "User Nick:" + Nick + "\n" +
                                      "User Email:" + Email + "\n" +
                                      "Description:\n" + Description;

                extras.sendEmail(Topic, emailContent);
                statusControl.ForeColor = System.Drawing.Color.Green;
                statusControl.Text = "Message sent successfully";
                Response.AddHeader("REFRESH", "1;URL=Home.aspx");
            }
        }

        private bool FormValidation()
        {
            GwmExtras extras = new GwmExtras();
            statusControl.ForeColor = System.Drawing.Color.Red;
            if (!extras.IsEmailValid(Email))
            {
                statusControl.Text = "Wrong email address";
                return false;
            }
            else if(Nick=="")
            {
                statusControl.Text = "Write your nickname";
                return false;
            }
            else if(Topic=="")
            {
                statusControl.Text = "Write topic";
                return false;
            }
            else if(Description=="")
            {
                statusControl.Text = "Write description";
                return false;
            }
            else if (Description.Count() <20)
            {
                statusControl.Text = "Description is too short";
                return false;
            }

            return true;
        }

        private string Email
        {
            get { return EmailControl.Text; }       
            set { EmailControl.Text = value; }        
        }

        private string Nick
        {
            get { return NameControl.Text; }
            set { NameControl.Text = value; }
        }
        private string Description
        {
            get { return DescriptionControl.Text; }
            set { DescriptionControl.Text = value; }
        }

        private string Topic
        {
            get {return TopicControl.Text; }
            set { TopicControl.Text = value; }
        }
    }
}