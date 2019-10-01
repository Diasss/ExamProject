using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject.Code
{
    public class FillComboBox
    {
        public static void Fill(ComboBox comboBox)
        {
            string cmdstr = "SELECT * FROM Groups";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        comboBox.Items.Add(name);
                    }
                }
            }
        }
    }
}
