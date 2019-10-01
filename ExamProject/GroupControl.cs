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
    public partial class GroupControl : UserControl
    {
        public GroupControl()
        {
            InitializeComponent();
            SlidePanel(addGroupButton, slidePanel1);
            addGroupControl1.BringToFront();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            SlidePanel(addGroupButton, slidePanel1);
            addGroupControl1.BringToFront();
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            SlidePanel(deleteGroupButton, slidePanel1);
            deleteGroupControl1.BringToFront();
        }

        private void infoGroupButton_Click(object sender, EventArgs e)
        {
            SlidePanel(infoGroupButton, slidePanel1);
            infoGroupControl1.BringToFront();
        }
        public static void SlidePanel(Button button, Panel panel)
        {
            panel.Height = button.Height;
            panel.Top = button.Top;
        }
    }
}
