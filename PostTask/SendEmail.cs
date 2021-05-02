using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PostTask
{
    class SendEmail
    {
        //public static void Email(string htmlString)
        //{
        //    try
        //    {
        //        MailMessage message = new MailMessage();
        //        SmtpClient smtp = new SmtpClient();
        //        message.From = new MailAddress("sadixovmurad322@gmail.com");
        //        message.To.Add(new MailAddress("sadixovmurad322@gmail.com"));
        //        message.Subject = "Test";
        //        message.IsBodyHtml = true; //to make message body as html  
        //        message.Body = htmlString;
        //        smtp.Port = 587;
        //        smtp.Host = "smtp.gmail.com"; //for gmail host  
        //        smtp.EnableSsl = true;
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Credentials = new NetworkCredential("sadixovmurad322@gmail.com", "0775966907m");
        //        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        smtp.Send(message);
        //    }
        //    catch (Exception) { }
        //}

        public static void SendMail()
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("sadixovmurad322@gmail.com", "0775966907m"),
                EnableSsl = true,
            };
            smtpClient.Send("sadixovmurad322@gmail.com", "sadixovmurad322@gmail.com", "Murad", $"Salam");
        }
    }
}
