using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class RestorePassword
    {
        public static bool Restore(string pass)
        {

            string cmdstr = "UPDATE Users SET password = '" + MD5HashPassword.GetHash(pass) + "' WHERE email = '" + ConfirmEmailToChangePassword.address + "'";
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
