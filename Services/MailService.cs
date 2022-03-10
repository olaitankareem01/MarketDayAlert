using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Text;
using MarketDayAlertApp.Models.DTOs;

namespace MarketDayAlertApp.Services
{
    public class MailService : IMailService
    {
        public MailService()
        {

        }

        public void SendMail(/*MailDto mail*/)
        {
            try
            {

                string to = "kabdrahman01@gmail.com"; //To address    
                string from = "olaitankareem01@gmail.com"; //From address    
                MailMessage message = new MailMessage(from, to);

                string mailbody = "In this article you will learn how to send a email using Asp.Net & C#";
                message.Subject = "Sending Email Using Asp.Net & C#";
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("olaitankareem01@gmail.com", "tsquare0601");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }


            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
