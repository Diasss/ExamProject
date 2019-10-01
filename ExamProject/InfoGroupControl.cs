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
    public partial class InfoGroupControl : UserControl
    {
        public static DataGridView data;
        public InfoGroupControl()
        {
            InitializeComponent();
            FillDataGridView(dataGridView1);
            data = dataGridView1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static void FillDataGridView(DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Groups", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                grid.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
