using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamProject
{
    public partial class DismissTeacherControl : UserControl
    {
        public static ComboBox ComboBox;
        public DismissTeacherControl()
        {
            InitializeComponent();
            FillCombobox(comboBox1);
            ComboBox = comboBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Code.DismissStudent.Dismiss(Convert.ToString(comboBox1.SelectedItem), false, label2);
            FillCombobox(comboBox1);
            InfoTeacherControl.FillDataGridView(InfoTeacherControl.data);
        }
        public static void FillCombobox(ComboBox box)
        {
            string cmdstr = "SELECT id, fName, lName FROM Users WHERE id_roles = 3";
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = "" + reader.GetString(1) + " " + reader.GetString(2) + "";
                        box.Items.Add(name);
                    }
                }
            }
        }
    }
}
