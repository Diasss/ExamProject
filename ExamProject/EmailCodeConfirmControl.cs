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
    public partial class EmailCodeConfirmControl : UserControl
    {
        public EmailCodeConfirmControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ConfirmEmailToChangePassword.code)
            {
                this.SendToBack();
            }
        }
        public static string ReturnCode(string code)
        {
            return code;
        }
    }
}
