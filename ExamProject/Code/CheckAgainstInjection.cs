using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class CheckAgainstInjection
    {
        public static bool Check(string field, string field2)
        {
            if (field.Contains(" ") || field.Contains("_") || field.Contains("-") || field.Contains("?") || field.Contains("!") ||
                field2.Contains(" ") || field2.Contains("_") || field2.Contains("-") || field2.Contains("?") || field2.Contains("!"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
