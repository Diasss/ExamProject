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
    public class DismissStudent
    {
        /// <summary>
        /// Если teachOrStud = true - Студент
        /// Иначе - Учитель
        /// </summary>
        /// <param name="name"></param>
        /// <param name="teachOrStud"></param>
        public static void Dismiss(string name, bool teachOrStud, Label label)
        {
            string[] words = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int tors;
            if (teachOrStud == true)
            {
                tors = 2;
            }
            else
            {
                tors = 3;
            }
            string cmdstr = "DELETE FROM Users where fName = '"+words[0]+"' AND lName = '"+words[1]+"' AND id_roles = "+tors+"";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    label.ForeColor = Color.Green;
                    label.Text = "Successfully deleted";
                }
                else
                {
                    label.Text = "Error404";
                }
            }
        }
    }
}
