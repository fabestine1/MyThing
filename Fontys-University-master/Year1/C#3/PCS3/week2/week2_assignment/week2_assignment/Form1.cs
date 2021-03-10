using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2_assignment
{
    public partial class Form1 : Form
    {
        //Student student;
        //Teacher teacher;
        School school;
        Person p;
        List<Person> personList;
       


        public Form1()
        {
            InitializeComponent();
            school = new School("John F. Kennedy");
            personList = new List<Person>();

            grpStudent.Visible = false;
            grpTeacher.Visible = false;

        }
        private Person CreatePerson()
        {
            int pcn = Convert.ToInt32(tbPcn.Text);
            String name = Convert.ToString(tbName.Text);
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYearsAtSchool.Text);

            return p = new Person(name, age, pcn, yearsAtSchool);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            bool answer;
             
            int pcn = Convert.ToInt32(tbPcn.Text);
            String name = Convert.ToString(tbName.Text);
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYearsAtSchool.Text);


            if(rbPerson.Checked)
            {

                p = new Person(name, age, pcn, yearsAtSchool);
                answer = school.AddPerson(p);
                 if (answer == true)
                    MessageBox.Show("Adding of person was successfull.");
                else
                    MessageBox.Show("Something went wrong.");

            }
            if(rbStudent.Checked)
            {
                String country = Convert.ToString(tbCountry.Text);
                int ec = Convert.ToInt32(tbEc.Text);
                grpStudent.Visible = true;

                p = new Student(name, age, pcn, yearsAtSchool, country, ec);
                answer = school.AddPerson(p);
                if (answer == true)
                    MessageBox.Show("Adding of person was successfull.");
                else
                    MessageBox.Show("Something went wrong.");

            }
            if (rbTeacher.Checked)
            {
                double salary = Convert.ToDouble(tbSalary.Text);
                grpTeacher.Visible = true;

                p = new Teacher(name, age, pcn, yearsAtSchool, salary);
                answer = school.AddPerson(p);
                if (answer == true)
                    MessageBox.Show("Adding of person was successfull.");
                else
                    MessageBox.Show("Something went wrong.");

            }
     
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Add(p.AsString());
            tbDisplayName.Text = p.Name;
            tbDisplayPcn.Text = Convert.ToString(p.PCN);
        }

        private void rbPerson_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            grpStudent.Visible = true;
            grpTeacher.Visible = false;
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            grpTeacher.Visible = true;
            grpStudent.Visible = false;
        }

        private void btnBDay_Click(object sender, EventArgs e)
        {

            p.CelebrateBirthday();
        }

        private void btnNewYear_Click(object sender, EventArgs e)
        {
            p.StartAnotherSchoolyear();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();

            school.GetPersons();

        }

        private void btnSearchPcn_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();

            school.GetPersonPCN(Convert.ToInt32(tbSearchByPcn.Text));
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();

            school.GetPersonName((tbSearchByPcn.Text));
        }

        private void btnYoungerThan_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();

            school.GetYoungPersons(Convert.ToInt32(tbYoungerThan.Text));
        }
    }

}
