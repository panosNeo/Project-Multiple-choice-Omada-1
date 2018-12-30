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


        public Mail()
        {
            code = "000000";
        }

        public void sendMessage(string mailTo, string subject, string body, bool hasCode)
        {
            this.mailTo = new MailAddress(mailTo);
            msg = new MailMessage();
            msg.Subject = subject;
            msg.From = new MailAddress("quizmakerteamGR@gmail.com");
            msg.Body = hasCode ? body + " " + code : body;
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
            Random r = new Random();
            code = "" + r.Next(10) + r.Next(10) + r.Next(10) + r.Next(10) + r.Next(10) + r.Next(10);
            return code;
        }
    }
}
