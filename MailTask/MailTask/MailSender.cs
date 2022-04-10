using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MailTask
{
   static class MailSender
    {
        public static void SendMail(string Email,string Title,string Messagge)
        {
            string mailAdress = "daniz7030571@mail.com";
            SmtpClient client = new SmtpClient(Email);
            //client.Credentials = new NetworkCredential(mailAdress, "******");
            //client.EnableSsl = true;
           
            MailAddress from = new MailAddress(mailAdress,"Sevda");
            MailAddress to = new MailAddress(Email);
            MailMessage message = new MailMessage(from, to);

            message.Subject = Title;
            message.Body = Messagge;
            message.IsBodyHtml = false;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            client.Send(message);
            message.Dispose();


            //try
            //{
            //    client.Send(message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception caught in CreateCopyMessage(): {0}",
            //        ex.ToString());
            //}
        }
    }
}
