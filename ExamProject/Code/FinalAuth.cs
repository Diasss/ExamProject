using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject.Code
{
    public class FinalAuth
    {
        public static void Auth(Label label, string login, string password, Form form)
        {
            if (CheckAgainstInjection.Check(login, password) == true)
            {
                string hashPassword = MD5HashPassword.GetHash(password);
                if (AuthAdminStudentTeacher.Auth(login, hashPassword) == 1)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    form.Hide();
                }
                else if (AuthAdminStudentTeacher.Auth(login, hashPassword) == 2)
                {
                    StudentForm studentForm = new StudentForm();
                    studentForm.Show();
                    form.Hide();
                }
                else if (AuthAdminStudentTeacher.Auth(login, hashPassword) == 3)
                {

                }
                else if (AuthAdminStudentTeacher.Auth(login, hashPassword) == 0)
                {
                    label.Text = "Неправильный логин или пароль";
                }
            }
            else
            {
                label.Text = "Логин или пароль не может содержать пробелы";
            }
        }

    }
}
