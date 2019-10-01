using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class ConnectionString
    {
        private static string _connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public static string Connstr { get => _connstr; private set => _connstr = value; }
    }
}
