using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class CheckEmailInDatabase
    {
        public static bool Check(string address)
        {
            string cmdstr = "SELECT * FROM Users WHERE email = '" + address + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
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
}
