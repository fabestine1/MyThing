using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_week1_
{
    public partial class Form1 : Form
    {
        Person person;
        Student student;
        Teacher teacher;
        public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {

            int pcn = Convert.ToInt32(tbPcn.Text);
            String name = Convert.ToString(tbName.Text);
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYears.Text);
            String country = Convert.ToString(tbCountry.Text);
            int ec = Convert.ToInt32(tbEC.Text);
            double salary = Convert.ToInt32(tbEC.Text);
            person = new Person(name, age, pcn, yearsAtSchool);
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {

            int pcn = Convert.ToInt32(tbPcn.Text);
            String name = Convert.ToString(tbName.Text);
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYears.Text);
            String country = Convert.ToString(tbCountry.Text);
            int ec = Convert.ToInt32(tbEC.Text);
            double salary = Convert.ToInt32(tbEC.Text);
            student = new Student(name, age, pcn, yearsAtSchool, country, ec);
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {

            int pcn = Convert.ToInt32(tbPcn.Text);
            String name = Convert.ToString(tbName.Text);
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYears.Text);
            String country = Convert.ToString(tbCountry.Text);
            int ec = Convert.ToInt32(tbEC.Text);
            double salary = Convert.ToInt32(tbEC.Text);
            teacher = new Teacher(name, age, pcn, yearsAtSchool, salary);
        }

        private void btnInfoPerson_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(person.AsString());
        }

        private void btnInfoStudent_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(student.AsString());
        }

        private void btnInfoTeacher_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(teacher.AsString());
        }



        //methods
        private void ShoowInfoPerson(Person p)
        {
            p.AsString();
        }
        private void ShoowInfoStudent(Student p)
        {
            p.AsString();
        }
        private void ShoowInfoTeacher(Teacher p)
        {
            p.AsString();
        }
    }
}
