using GoWithMe.Model.ModelDB;
using GoWithMe.Model.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe
{
    public partial class HelpdeskLogin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContinueControl_Click(object sender, EventArgs e)
        {
            tblUser user = new tblUser();

            if (loginProblemControl.Checked && passwordProblemControl.Checked)
            {
                ITblUserRepository repo = new TblUserRepository();
                user = repo.GetUserByGivenEmailAddress(emailProblemControl.Text);
                if (user.Login == null)
                {
                    ResultControl.ForeColor = System.Drawing.Color.Red;
                    ResultControl.Text = "Given email adress doesnt exist in database";
                }
                else
                {
                    string newUserPassword = repo.ResetPasswordLoginHelpdesk(user);


                    string emailBodyMessage = "Your login is:\n" + user.Login + "\nNew password for you account is: \n" + user.Password + "\nBest wishes, gowitme team :)";

                    bool isEmailSent = sendEmail("Your login and password", emailProblemControl.Text, emailBodyMessage);

                    if (isEmailSent == false)
                    {
                        ResultControl.ForeColor = System.Drawing.Color.Red;
                        ResultControl.Text = "Unexpected aplication error appeared.\n Try to contact servis administrator";
                    }
                    else if (isEmailSent == true)
                    {
                        ResultControl.ForeColor = System.Drawing.Color.Green;
                        ResultControl.Text = "Message with login and new password to your account was sent to your email address";
                        Response.AddHeader("REFRESH", "15;URL=Home.aspx");
                    }
                }

            }
            else if (loginProblemControl.Checked)
            {
                ITblUserRepository repo = new TblUserRepository();
                user = repo.GetUserByGivenEmailAddress(emailProblemControl.Text);
                if(user .Login== null)
                {
                    ResultControl.ForeColor = System.Drawing.Color.Red;
                    ResultControl.Text = "Given email adress doesnt exist in database";
                }
                else
                {
                    string emailBodyMessage="Reminding your login name in application gowithme.net\n"+
                                            "Your login is:\n" + user.Login + "Best wishes, gowitme team :)";
                    bool isEmailSent= sendEmail("Reminding user login name:", emailProblemControl.Text ,emailBodyMessage);

                    if(isEmailSent == false)
                    {
                        ResultControl.ForeColor = System.Drawing.Color.Red;
                        ResultControl.Text = "Unexpected aplication error appeared.\n Try to contact servis administrator";
                    }
                    else if(isEmailSent == true)
                    {
                        ResultControl.ForeColor = System.Drawing.Color.Green;
                        ResultControl.Text = "Message with your login name was send to your email";
                        Response.AddHeader("REFRESH", "15;URL=Home.aspx");
                    }
                }
            }
            else if (passwordProblemControl.Checked)
            {
                ITblUserRepository repo = new TblUserRepository();
                user = repo.GetUserByGivenEmailAddress(emailProblemControl.Text);
                if (user.Login == null)
                {
                    ResultControl.ForeColor = System.Drawing.Color.Red;
                    ResultControl.Text = "Given email adress doesnt exist in database";
                }
                else
                {
                    string newUserPassword = repo.ResetPasswordLoginHelpdesk(user);


                    string emailBodyMessage = "Nowe password for your account: \n" + user.Password + " \n Best wishes, gowitme team :)";

                    bool isEmailSent = sendEmail("Reset hasła", emailProblemControl.Text, emailBodyMessage);

                    if (isEmailSent == false)
                    {
                        ResultControl.ForeColor = System.Drawing.Color.Red;
                        ResultControl.Text = "Unexpected aplication error appeared.\n Try to contact servis administrator";
                    }
                    else if (isEmailSent == true)
                    {
                        ResultControl.ForeColor = System.Drawing.Color.Green;
                        ResultControl.Text = "Message with new password for your account was sent to your email";
                        Response.AddHeader("REFRESH", "15;URL=Home.aspx");
                    }
                }

            }
            
            else {
                ResultControl.ForeColor = System.Drawing.Color.Red;
                ResultControl.Text = "None field was choosen";
            }

            
        }


        private static bool sendEmail(string emailSubject,string GivenEmailAddres, string emailBodyMessage)
        {
            /*DANE DO SMTP
            login: gowithmesite@gmail.com
            haslo:Gowithme
            */

            string FROM = "gowithmesite@gmail.com";
            string USERNAME = "gowithmesite@gmail.com";
            string PASSWORD = "Gowithme";
            string SMTP = "smtp.gmail.com";



            // MailMessage mail = new MailMessage(FROM, textBox_TO.Text, textBox_SUBJECT.Text, textBox_BODY.Text);
            MailMessage mail = new MailMessage(FROM, GivenEmailAddres, emailSubject, emailBodyMessage);
            //add attachment:
            //mail.Attachments.Add(new Attachment(PathToPDFFile));


            // SmtpServer = smtp.company.com; Ex: Gmail - smtp.gmail.com | Yahoo - smtp.yahoo.com
            SmtpClient client = new SmtpClient(SMTP);
            // Port 587 is the preffered port for mail submission. Port 25 is widely abused by malware to spread worms
            // As a result, many ISPs are restricting its use. I tried to use it but it didn't work!
            client.Port = 587;
            client.Credentials = new NetworkCredential(USERNAME, PASSWORD);

            // Port 587 allows you to use a SSL Connection.
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
               
            }

            
        }
    }
}