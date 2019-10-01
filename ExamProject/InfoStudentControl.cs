﻿using System;
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
    public partial class InfoStudentControl : UserControl
    {
        public static DataGridView data;
        public InfoStudentControl()
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE id_roles = 2", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                grid.DataSource = dt;
            }
        }
    }
}
