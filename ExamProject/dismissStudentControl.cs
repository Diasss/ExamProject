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
    public partial class dismissStudentControl : UserControl
    {
        public static ComboBox ComboBox;
        public dismissStudentControl()
        {
            InitializeComponent();
            FillCombobox(comboBox1);
            ComboBox = comboBox1;
        }

        private void dismissStudentControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Code.DismissStudent.Dismiss(Convert.ToString(comboBox1.SelectedItem), true, label2);
            comboBox1.Text = "";
            FillCombobox(comboBox1);
            InfoStudentControl.FillDataGridView(InfoStudentControl.data);
        }
        public static void FillCombobox(ComboBox box)
        {
            box.Items.Clear();
            string cmdstr = "SELECT id, fName, lName FROM Users WHERE id_roles = 2";
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = ""+reader.GetString(1)+" "+reader.GetString(2)+"";
                        box.Items.Add(name);
                    }
                }
            }
        }
    }
}
