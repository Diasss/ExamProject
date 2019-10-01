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
    public partial class LessonsControl : UserControl
    {
        public LessonsControl()
        {
            InitializeComponent();
            SlidePanel(addLessonsButton, slidePanel1);
            addLessonControl1.BringToFront();
        }

        private void addLessonsButton_Click(object sender, EventArgs e)
        {
            SlidePanel(addLessonsButton, slidePanel1);
            addLessonControl1.BringToFront();
        }

        private void deleteLessonsButton_Click(object sender, EventArgs e)
        {
            SlidePanel(deleteLessonsButton, slidePanel1);
            deleteLessonControl1.BringToFront();
        }

        private void infoLessonsButton_Click(object sender, EventArgs e)
        {
            SlidePanel(infoLessonsButton, slidePanel1);
            infoLessonControl1.BringToFront();
        }
        public static void SlidePanel(Button button, Panel panel)
        {
            panel.Height = button.Height;
            panel.Top = button.Top;
        }
    }
}
