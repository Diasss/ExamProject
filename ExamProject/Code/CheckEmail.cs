using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class CheckEmail
    {
        public static bool IsValidEmail(string email)
        {
            var addr = new System.Net.Mail.MailAddress(email);

            if (addr.Address == email)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
