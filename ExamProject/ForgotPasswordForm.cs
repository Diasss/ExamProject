using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class ForgotPasswordForm : Form
    {
        public static ForgotPasswordForm ForgotForm;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            ForgotForm = this;
        }

        private void confirmEmailToChangePassword1_Load(object sender, EventArgs e)
        {

        }
    }
}
