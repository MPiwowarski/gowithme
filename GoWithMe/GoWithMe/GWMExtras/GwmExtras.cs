using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace GoWithMe.GWMExtras
{
    public class GwmExtras
    {
        public static string ChangeNumberFormat(string number)
        {
            number = number.Insert(3, "-");
            number = number.Insert(7, "-");
            return number;
        }

        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool sendEmail(string emailSubject, string emailBodyMessage)
        {
            /*Data to smtp
            login: gowithmesite@gmail.com
            haslo:Gowithme
            */

            string GivenEmailAddres= "gowithmesite@gmail.com";

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