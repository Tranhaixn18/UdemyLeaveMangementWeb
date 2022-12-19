using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementWeb.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string formEmailAddress;

        public EmailSender(string smtpServer, int smtpPort, string formEmailAddress)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.formEmailAddress = formEmailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var mesage = new MailMessage
            {
                From = new MailAddress(formEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };  
            //xac dinh ai se gui mail
            mesage.To.Add(new MailAddress(email));
            using(var client = new SmtpClient(smtpServer, smtpPort))
            {
                client.Send(mesage);
            }
            return Task.CompletedTask;
        }
    }
}
