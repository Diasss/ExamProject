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
    public partial class AddLessonControl : UserControl
    {
        public AddLessonControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewLesson(textBox1.Text, label3);
            DeleteLessonControl.FillCombobox(DeleteLessonControl.ComboBox);
            infoLessonControl.FillDataGridView(infoLessonControl.data);
        }
        public static void AddNewLesson(string name, Label label)
        {
            string cmdstr = "INSERT Subjects VALUES('" + name + "')";
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    label.ForeColor = Color.Green;
                    label.Text = "Successfully added";
                }
                else
                {
                    label.ForeColor = Color.Red;
                    label.Text = "error";
                }
            }
        }
    }
}
