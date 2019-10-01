using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class SendCodeToMail
    {
        public static void Send(string code, string address)
        {
            MailAddress from = new MailAddress("dias.project@mail.ru");
            MailAddress to = new MailAddress("dasik.osp@mail.ru");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Password recovery";
            message.Body = "Your code = " + code + "";
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("dias.project@mail.ru", "fcbzlbfc123");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
