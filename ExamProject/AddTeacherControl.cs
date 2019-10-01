using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamProject
{
    public partial class AddTeacherControl : UserControl
    {
        public AddTeacherControl()
        {
            InitializeComponent();
            FillDate(comboBox2, comboBox3, comboBox4);  
        }

        private void AddTeacherControl_Load(object sender, EventArgs e)
        {

        }

        private void registrateButton_Click(object sender, EventArgs e)
        {
            Registrate(nameTextBox.Text, lnameTextBox.Text, loginTextBox.Text, passwordTextBox.Text, emailTextBox.Text, ReturnDate(comboBox2.SelectedItem.ToString(), (string)comboBox3.SelectedItem, comboBox4.SelectedItem.ToString()), phoneTextBox.Text, label10);
            InfoTeacherControl.FillDataGridView(InfoTeacherControl.data);
            DismissTeacherControl.FillCombobox(DismissTeacherControl.ComboBox); 
        }
        public static void Registrate(string name, string lname, string login, string password, string email, string bdate, string phone, Label label)
        {
            string cmdstr = "INSERT Users VALUES('" + login + "', '" + Code.MD5HashPassword.GetHash(password) + "', '" + name + "', '" + lname + "', '" + phone + "', '" + bdate + "', " + 3 + ", null, '" + email + "')";
            using (SqlConnection conn = new SqlConnection(Code.ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    label.ForeColor = Color.FromArgb(118, 166, 46);
                    label.Text = "Successfully added";
                }
                else
                {
                    label.ForeColor = Color.FromArgb(166, 27, 15);
                    label.Text = "Wrong data";
                }
            }
        }
        public static void FillDate(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            foreach (string m in monthNames)
            {
                comboBox2.Items.Add(m);
            }
            for (int i = 1950; i < 2012; i++)
            {
                comboBox3.Items.Add(i);
            }
        }
        public static string ReturnMotnh(string month)
        {
            if (month == "Январь")
            {
                return "01";
            }
            else if (month == "Февраль")
            {
                return "02";
            }
            else if (month == "Март")
            {
                return "03";
            }
            else if (month == "Апрель")
            {
                return "04";
            }
            else if (month == "Май")
            {
                return "05";
            }
            else if (month == "Июнь")
            {
                return "06";
            }
            else if (month == "Июль")
            {
                return "07";
            }
            else if (month == "Август")
            {
                return "08";
            }
            else if (month == "Сентябрь")
            {
                return "09";
            }
            else if (month == "Октябрь")
            {
                return "10";
            }
            else if (month == "Ноябрь")
            {
                return "11";
            }
            else if (month == "Декабрь")
            {
                return "12";
            }
            else
            {
                return "00";
            }
        }
        public static string ReturnDate(string day, string month, string year)
        {
            DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(ReturnMotnh(month)), Convert.ToInt32(day));
            string d = "" + date.Year + "-" + date.Month + "-" + date.Day + "";
            return d;
        }
    }
}
