using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraineeRegistration
{
    public partial class Form1 : Form
    {
        private Trainee trainee;
        private CourseLevel selectedLevel;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Created by Nikolay Nikolaev";
        }

        private void btnCreateTrainee_Click(object sender, EventArgs e)
        {
            trainee = new Trainee(tbName.Text, Convert.ToInt32(tbAge.Text));
            this.Text += " :: Details for " + trainee.Name;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if(!trainee.RegisterForCourse(cbCourses.Text, selectedLevel))
            {
                MessageBox.Show("The trainee is already registered for that course!");
            }
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            if (!trainee.ChangeCourse(cbCourses.Text, selectedLevel))
            {
                MessageBox.Show("The trainee is not registered for that course!");
            }
        }

        private void btnShowAllCourses_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();
            foreach(Course course in trainee.GetAllCourses())
            {
                lbCourses.Items.Add(course.AsString());
            }
        }

        private void btnShowBeginnerCourses_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();
            foreach (Course course in trainee.GetAllBeginnerCourses())
            {
                lbCourses.Items.Add(course.AsString());
            }
        }

        private void btnShowBillingDetails_Click(object sender, EventArgs e)
        {
            int sum = 0;
            tbBillingName.Text = trainee.Name + ", " + trainee.Age;
            tbBillingNrOfCourses.Text = trainee.GetAllCourses().Count.ToString();
            foreach(Course course in trainee.GetAllCourses())
            {
                sum += course.GetPrice();
            }
            tbBillingTotalPrice.Text = sum.ToString();
        }

        private void rbBeginner_CheckedChanged(object sender, EventArgs e)
        {
            selectedLevel = CourseLevel.BEGINNER;
        }

        private void rbIntermediate_CheckedChanged(object sender, EventArgs e)
        {
            selectedLevel = CourseLevel.INTERMEDIATE;
        }

        private void rbAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            selectedLevel = CourseLevel.ADVANCED;
        }
    }
}
