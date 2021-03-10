using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        private Teacher teacher;
        private Student student;
        private GraduatedStudent graduatedStudent;

        public Form1()
        {
            InitializeComponent();
            teacher = new Teacher("Edna Krabappel", 111111, 36, Function.DOCENT_1, 1500, "Rachelsmolen 1"); // create a teacher
            labelTeacher.Text = teacher.ToString();

            LogTeacherChange("start");

            student = new Student("John Brown", 215242, 18, "USA", "Rachelsmolen 1"); // create a student
            labelStudent.Text = student.ToString();

            LogStudentChange("start");

            graduatedStudent = new GraduatedStudent("John Brown", 215242, 18, "Rachelsmolen 1", 2008, 10); // create a student
            labelGraduatedStudent.Text = graduatedStudent.ToString();

            LogGraduatedStudentChange("start");
        }


        private void LogTeacherChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n"+teacher.ToString());
        }

        private void LogStudentChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n" + student.ToString());
        }

        private void LogGraduatedStudentChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n" + graduatedStudent.ToString());
        }


        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            teacher.StartAnotherSchoolYear();
            LogTeacherChange("another school year");
        }

        private void buttonBirthdayTeacher_Click(object sender, EventArgs e)
        {
            teacher.CelebrateBirthday();
            LogTeacherChange("birthday");
        }

        private void buttonPromote_Click(object sender, EventArgs e)
        {
            teacher.Promote();
            LogTeacherChange("promotion");
        }

        private void buttonSchoolYearStudent_Click(object sender, EventArgs e)
        {
            student.StartAnotherSchoolYear();
            LogStudentChange("another school year");
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            student.CelebrateBirthday();
            LogStudentChange("birthday");
        }

        private void buttonAddModule_Click(object sender, EventArgs e)
        {
            student.AddECs(1);
            LogStudentChange("Added module ECs");
        }

        private void buttonShowAddressTeacher_Click(object sender, EventArgs e)
        {
            MessageBox.Show(teacher.Address);
        }

        private void buttonShowAddressStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(student.Address);
        }

        private void buttonCelebrateBirthDayGrad_Click(object sender, EventArgs e)
        {
            graduatedStudent.CelebrateBirthday();
            LogGraduatedStudentChange("birthday");
        }

        private void buttonShowAdressGrad_Click(object sender, EventArgs e)
        {
            MessageBox.Show(graduatedStudent.Address);
        }
    }
}
