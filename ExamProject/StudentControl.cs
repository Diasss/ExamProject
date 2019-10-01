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
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
            SlidePanel(addStudentButton, slidePanel1);
            addStudentControl1.BringToFront();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            SlidePanel(addStudentButton, slidePanel1);
            addStudentControl1.BringToFront();
        }

        private void dismissStudentButton_Click(object sender, EventArgs e)
        {
            SlidePanel(dismissStudentButton, slidePanel1);
            dismissStudentControl1.BringToFront();
        }

        private void infoStudentButton_Click(object sender, EventArgs e)
        {
            SlidePanel(infoStudentButton, slidePanel1);
            infoStudentControl1.BringToFront();
        }
        public static void SlidePanel(Button button, Panel panel)
        {
            panel.Height = button.Height;
            panel.Top = button.Top;
        }
    }
}
