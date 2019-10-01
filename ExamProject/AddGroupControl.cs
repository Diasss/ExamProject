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
    public partial class AddGroupControl : UserControl
    {
        public AddGroupControl()
        {
            InitializeComponent();
            
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            AddGroup(groupsNameTextBox.Text, label3);
            DeleteGroupControl.FillCombobox(DeleteGroupControl.ComboBox);
            InfoGroupControl.FillDataGridView(InfoGroupControl.data);
        }
        public static void AddGroup(string text, Label label)
        {
            string cmdstr = "INSERT Groups VALUES('" + text + "')";
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
