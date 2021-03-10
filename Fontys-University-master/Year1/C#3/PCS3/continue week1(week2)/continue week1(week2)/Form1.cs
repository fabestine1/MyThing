using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace continue_week1_week2_
{
    public partial class Form1 : Form
    {
        Person person;
        Student student;
        Teacher teacher;

        //methods
        private String ShowInfoPerson(Person p)
        {
            return p.AsString();
        }
        private String ShowInfoStudent(Student p)
        {
            return p.AsString();
        }
        private String ShowInfoTeacher(Teacher p)
        {
            return p.AsString();
        }

        public Form1()
        {
            InitializeComponent();
            grpbStudent.Visible = false;
            grpbTeacher.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            person = new Person(Convert.ToString(tbName.Text),
                                  Convert.ToInt32(tbAge.Text),
                                  Convert.ToInt32(tbPcn.Text),
                                  Convert.ToInt32(tbYearsSchool.Text));
        }

        private void btnInfoPerson_Click(object sender, EventArgs e)
        {
            person = new Person(Convert.ToString(tbName.Text),
                                  Convert.ToInt32(tbAge.Text),
                                  Convert.ToInt32(tbPcn.Text),
                                  Convert.ToInt32(tbYearsSchool.Text));
            tbDisplayName.Text = String.Empty;
            lbInfo.Items.Add(ShowInfoPerson(person));
            tbDisplayName.Text = Convert.ToString(tbName.Text);
            tbDisplayPcn.Text = Convert.ToString(tbPcn.Text);
        }

        private void rbPerson_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
                grpbStudent.Visible = true;
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTeacher.Checked)
                grpbTeacher.Visible = true;
        }
    }
}
