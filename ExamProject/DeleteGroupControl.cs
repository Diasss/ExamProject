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
    public partial class DeleteGroupControl : UserControl
    {
        public static ComboBox ComboBox;
        public DeleteGroupControl()
        {
            InitializeComponent();
            FillCombobox(comboBox1);
            ComboBox = comboBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteLesson(Convert.ToString(comboBox1.SelectedItem), label2);
            comboBox1.Text = "";
            FillCombobox(comboBox1);
            InfoGroupControl.FillDataGridView(InfoGroupControl.data);
        }
        public static void FillCombobox(ComboBox box)
        {
            box.Items.Clear();
            string cmdstr = "SELECT * FROM Groups";
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        box.Items.Add(name);
                    }
                }
            }
        }
        public static void DeleteLesson(string name, Label label)
        {
            string cmdstr = "DELETE FROM Groups WHERE name = '" + name + "'";
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
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
                    label.ForeColor = Color.Red;
                    label.Text = "error";
                }
            }
        }

        private void DeleteGroupControl_Load(object sender, EventArgs e)
        {

        }
    }
}
