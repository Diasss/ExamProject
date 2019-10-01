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
    public partial class TeacherControl : UserControl
    {
        public TeacherControl()
        {
            InitializeComponent();
            SlidePanel(addTeacherButton, slidePanel1);
            addTeacherControl1.BringToFront();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            SlidePanel(addTeacherButton, slidePanel1);
            addTeacherControl1.BringToFront();
        }

        private void dismissTeacherButton_Click(object sender, EventArgs e)
        {
            SlidePanel(dismissTeacherButton, slidePanel1);
            dismissTeacherControl1.BringToFront();
        }

        private void infoTeacherButton_Click(object sender, EventArgs e)
        {
            SlidePanel(infoTeacherButton, slidePanel1);
            infoTeacherControl1.BringToFront();
        }
        public static void SlidePanel(Button button, Panel panel)
        {
            panel.Height = button.Height;
            panel.Top = button.Top;
        }
    }
}
