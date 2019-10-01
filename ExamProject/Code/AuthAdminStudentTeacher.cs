using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Code
{
    public class AuthAdminStudentTeacher
    {
        public static int Auth(string login, string password)
        {
            string cmdstr = "SELECT * FROM Users WHERE login = '" + login + "' AND password = '" + password + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                var read = cmd.ExecuteReader();
                int k = 0;
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        k = (int)read.GetValue(7);
                    }
                    if (k == 1)
                    {
                        return 1;
                    }
                    else if (k == 2)
                    {
                        return 2;
                    }
                    else if (k == 3)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
