using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject.Code
{
    public class RetistrateNewUser
    {
        public static void Registrate(string name, string lname, string login, string password, string email, string bdate, string phone, int group_id, bool teacherOrStudent, Label label)
        {
            int role;
            //Teacher
            if (teacherOrStudent == true)
            {
                role = 3;
            }
            //Student
            else
            {
                role = 2;
            }
            string cmdstr = "INSERT Users VALUES('" + login + "', '" + MD5HashPassword.GetHash(password) + "', '" + name + "', '" + lname + "', '" + phone + "', '" + bdate + "', " + role + ", " + group_id + ", '" + email + "')";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
                {
                    label.ForeColor = Color.FromArgb(118, 166, 46);
                    label.Text = "Successfully added";
                }
                else
                {
                    label.ForeColor = Color.FromArgb(166, 27, 15);
                    label.Text = "Wrong data";
                }
            }
        }
    }
}
