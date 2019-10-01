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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homeControl1.BringToFront();
            SlidePanels(homeButton, slidePanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanels(homeButton, slidePanel);
            homeControl1.BringToFront();
        }
        private void teacherButton_Click(object sender, EventArgs e)
        {
            SlidePanels(teacherButton, slidePanel);
            teacherControl1.BringToFront();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            SlidePanels(studentButton, slidePanel);
            studentControl1.BringToFront();
        }

        private void lessonsButton_Click(object sender, EventArgs e)
        {
            SlidePanels(lessonsButton, slidePanel);
            lessonsControl1.BringToFront();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            SlidePanels(groupsButton, slidePanel);
            groupControl1.BringToFront();
        }
        public static void SlidePanels(Button button, Panel panel)
        {
            panel.Height = button.Height;
            panel.Top = button.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
