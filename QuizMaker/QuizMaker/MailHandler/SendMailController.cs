using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.MailHandler
{
    class SendMailController
    {
        private static Mail mail = new Mail();
        private static string verificationCode = "NaN";
        private static string passwordCode = "NaN";

        public static string getVerificationCode()
        {
            return verificationCode;
        }

        public static string getPasswordCode()
        {
            return passwordCode;
        }

        public static void SendSimpleMail(string to, string subject, string body, bool code)
        {
            mail.sendMessage(to, subject, body, false);
        }

        public static void SendVerificationMail(string to)
        {
            string subject = "Hello user";
            string body = "We need you to confirm that this e-mail is yours. "+
                "Please copy the code below and paste it into the app";
            verificationCode = mail.generateCode();
            mail.sendMessage(to, subject, body, true);
        }

        public static void SendPasswordResetMail(string to)
        {
            string subject = "Password reset";
            string body = "We need you to confirm that you want to change your password. " +
                "Please copy the code below and paste it into the app";
            passwordCode = mail.generateCode();
            mail.sendMessage(to, subject, body, true);
        }
    }
}
