using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class GenerateCode
    {
        public static string Generate()
        {
            Random rnd = new Random();
            string code = "" + (rnd.Next(0, 9)) + "" + (rnd.Next(0, 9)) + "" + (rnd.Next(0, 9)) + "" + (rnd.Next(0, 9)) + "";
            return code;
        }
    }
}
