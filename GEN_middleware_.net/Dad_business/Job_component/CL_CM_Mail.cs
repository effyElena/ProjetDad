using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Business.Job_component
{
    public class CL_CM_Mail
    {
        public async void sendMail(string url, string name, DateTime date, string content)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.dbcorp.fr"))
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("david.billiere@viacesi.fr");
                mailMessage.To.Add("agathe.phelipeau@viacesi.fr");
                mailMessage.Subject = "test";
                mailMessage.Body = "toto";
                mailMessage.IsBodyHtml = false;

                await smtpClient.SendMailAsync(mailMessage);
            }
        }


    }
}
