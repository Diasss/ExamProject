using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class Restore : UserControl

    {
        public Restore()
        {
            InitializeComponent();

        }      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox1.Text && textBox1.Text != null || textBox2.Text!=null)
            {
                if (Code.RestorePassword.Restore(textBox1.Text))
                {
                    MessageBox.Show("YEEEE");
                    ForgotPasswordForm.ForgotForm.Hide();
                }
                else
                {
                    MessageBox.Show("NOOOO");
                }
            }
        }
    }
}
