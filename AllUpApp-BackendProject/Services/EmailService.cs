using System.Net.Mail;
using System.Net;

namespace AllUpApp_BackendProject.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string body, string link, string userName)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress("sabirmextiev07@gmail.com", "Verify Email AllUp");
                mailMessage.To.Add(new MailAddress(email));
                mailMessage.Subject = subject;


                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;


                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;

                smtpClient.Credentials = new NetworkCredential("sabirmextiev07@gmail.com", "ugnd phgs oraz dfgf");
                smtpClient.Send(mailMessage);
            }
        }
    }
}
