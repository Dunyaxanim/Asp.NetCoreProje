using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
namespace CoreDemo4.Helpers
{
    public static class Helper
    {
        public static async Task SendMessage(string messageSubject, string messageBody, string mailTo, IFormFile Attachment)
        {

            SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("dunyaxanim.y@itbrains.az", "lfvjoqpcsxgmxfcp");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("dunyaxanim.y@itbrains.az", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.Attachments.Add(new Attachment(Attachment.OpenReadStream(), Attachment.FileName));
            await client.SendMailAsync(message);
        }

        public static async Task SendMessage(string messageSubject, string messageBody, string mailTo)
        {

            SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("dunyaxanim.y@itbrains.az", "lfvjoqpcsxgmxfcp");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("dunyaxanim.y@itbrains.az", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            await client.SendMailAsync(message);
        }

        public enum Roles
        {
            SuperAdmin,
            Admin,
            User

        }
        public static async Task SendEmail(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("your-email-address@gmail.com", "your-password"),
                EnableSsl = true
            };
            await client.SendMailAsync(new MailMessage(from: "your-email-address@gmail.com", to: email, subject: subject, body: message)
            {
                IsBodyHtml = true
            });
        }

    }
}
