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
        public Form1()
        {
            Text = $"Created by XXX";

            InitializeComponent();
        }

        private void btnCreateTrainee_Click(object sender, EventArgs e)
        {
            trainee = new Trainee(Convert.ToInt32(tbAge.Text), tbName.Text);
            this.Text = "Created by Kaloyan::Details for " + trainee.Name;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CourseLevel lvl = CourseLevel.BEGINNER;
            if (rbIntermediate.Checked)
            {
                lvl = CourseLevel.INTERMEDIATE;
            }
            else if (rbAdvanced.Checked)
            {
                lvl = CourseLevel.ADVANCED;
            }

            bool addedCourse = trainee.RegisterForCourse(cbCourses.Text, lvl);
            if (!addedCourse)
            {
                MessageBox.Show("Trainee is already registered for course with such code.");
            }
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            CourseLevel lvl = CourseLevel.BEGINNER;
            if (rbIntermediate.Checked)
            {
                lvl = CourseLevel.INTERMEDIATE;
            }
            else if (rbAdvanced.Checked)
            {
                lvl = CourseLevel.ADVANCED;
            }

            bool changedCourse = trainee.ChangeCourse(cbCourses.Text, lvl);
            if (changedCourse == false)
            {
                MessageBox.Show("Course can not be modified since the trainee is not yet enrolled with that code.");
            };
        }

        private void btnShowAllCourses_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();

            foreach (Course o in trainee.GetAllCourses())
            {
                lbCourses.Items.Add(o.AsString());
            }
        }

        private void btnShowBeginnerCourses_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();

            foreach (Course o in trainee.GetAllBeginnerCourses())
            {
                lbCourses.Items.Add(o.AsString());
            }
        }

        private void btnShowBillingDetails_Click(object sender, EventArgs e)
        {
            List<Course> traineeCourses = trainee.GetAllCourses();
            int totalPrice = 0;

            foreach (Course traineeCourse in traineeCourses)
            {
                totalPrice += traineeCourse.GetPrice();
            }

            tbBillingName.Text = trainee.Name + ", " + trainee.Age;
            tbBillingNrOfCourses.Text = Convert.ToString(traineeCourses.Count);
            tbBillingTotalPrice.Text = Convert.ToString(totalPrice);
        }
    }
}
