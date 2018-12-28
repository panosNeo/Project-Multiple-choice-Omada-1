using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace QuizMaker.MailHandler
{
    class Mail
    {
        
        private MailMessage msg;
        private SmtpClient smtp;
        private string subject, body;
        private MailAddress mailTo;
        private string code;

        public Mail(string subject, string body, string mailTo)
        {
            this.subject = subject;
            this.body = body;
            this.mailTo = new MailAddress(mailTo);
        }

        public void sendMessage()
        {
            msg = new MailMessage();
            msg.Subject = subject;
            msg.From = new MailAddress("quizmakerteamGR@gmail.com");
            msg.Body = body;
            msg.To.Add(mailTo);
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential("quizmakerteamGR@gmail.com", "quiz1995it123");
            smtp.Credentials = nc;
            smtp.Send(msg);
        }

        public string generateCode()
        {
            Random r = new Random(10);
            code = "" + r.Next(10) + r.Next(10) + r.Next(10) + r.Next(10) + r.Next(10) + r.Next(10);
            return code;
        }
    }
}
