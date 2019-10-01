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
    public partial class ConfirmEmailToChangePassword : UserControl
    {
        public static string code = Code.GenerateCode.Generate();
        public static string address;
        public ConfirmEmailToChangePassword()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                if (Code.CheckEmail.IsValidEmail(textBox1.Text) == true)
                {
                    if (Code.CheckEmailInDatabase.Check(textBox1.Text))
                    {
                        address = textBox1.Text;
                        Code.SendCodeToMail.Send(code, textBox1.Text);
                        this.SendToBack();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно!11!");
                }
            }
            else
            {
                MessageBox.Show("неправильно!11");
            }
        }
    }
}
