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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            studentsHomeControl1.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            SlidePanel(homeButton, slidePanel);
            studentsHomeControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanel(button1, slidePanel);
            examControl1.BringToFront();
        }
        public static void SlidePanel(Button button, Panel panel)
        {
            panel.Height = button.Height;
            panel.Top = button.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
