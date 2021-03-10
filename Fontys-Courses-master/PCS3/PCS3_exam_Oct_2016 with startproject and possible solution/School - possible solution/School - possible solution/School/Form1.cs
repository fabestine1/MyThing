using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        private School mySchool;
        public Form1()
        {
            InitializeComponent();
            this.mySchool = new School("Fontys ICT");
            this.AddSomeCoursesForTestPurpose();
        }

        /////////////////////////////// BEGIN YOUR CODE HERE /////////////////////////////////////////////////////

        // Assignment 4: 
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (this.lbCourseOverview.SelectedItem != null)
            {
                try
                {
                    Course c = (Course)this.lbCourseOverview.SelectedItem;
                    int participantId = Convert.ToInt32(this.tbParticipantId.Text);
                    String participantName = this.tbParticipantName.Text;
                    c.AddParticipant(participantId, participantName);
                    this.ShowAllCourses();
                }
                catch (FormatException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (CourseException exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
            else
            {
                MessageBox.Show("No course selected in the course overview");
            }
        }

        // Assignment 5: 
        private void btnOverviewAllThatTakePlace_Click(object sender, EventArgs e)
        {
            this.lbCourseOverview.Items.Clear();
            foreach (Course c in this.mySchool.GetAllCourses())
            {
                if (c is ClassroomCourse)
                {
                    if (((ClassroomCourse)c).WillTakePlace())
                        this.lbCourseOverview.Items.Add(c);
                }
                else
                {
                    this.lbCourseOverview.Items.Add(c);
                }
            }
        }

        // Assignment 6: 
        private void btnSaveOverview_Click(object sender, EventArgs e)
        {
            int totalECourse = 0;
            int totalClassroomCourse = 0;
            String filename = "../../revenue.txt";
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Course overview of school " + this.mySchool.GetName());
                sw.WriteLine("***** e-courses *****");
                foreach (Course c in this.mySchool.GetAllCourses())
                {
                    if (c is ECourse)
                    {
                        sw.WriteLine(c.ToString());
                        totalECourse += c.GetPricePerParticipant() * c.GetNrOfParticipants();
                    }
                }
                sw.WriteLine("***** classroom courses *****");
                foreach (Course c in this.mySchool.GetAllCourses())
                {
                    if (c is ClassroomCourse)
                    {
                        if (((ClassroomCourse)c).WillTakePlace())
                        {
                            sw.WriteLine(c.ToString());
                            totalClassroomCourse += c.GetPricePerParticipant() * c.GetNrOfParticipants();
                        }
                    }
                }
                sw.WriteLine("***** revenues *****");
                sw.WriteLine("The total revenue for E-courses is: " + totalECourse.ToString());
                sw.WriteLine("The total revenue for Classroom courses is: " + totalClassroomCourse.ToString());
            }
            catch (IOException)
            {
                MessageBox.Show("Something wrong with saving to file");
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }

        }


        ///////////////////////////////  END YOUR CODE HERE  /////////////////////////////////////////////////////

        private void AddSomeCoursesForTestPurpose()
        {
            Course c;
            c = new ClassroomCourse(100, "PCS3", 10, 25, 400);
            this.mySchool.AddCourse(c);
            c = new ECourse(200, "Jiu Jitsu", 1000);
            this.mySchool.AddCourse(c);
            c = new ECourse(201, "Kung Fu", 400);
            this.mySchool.AddCourse(c);
            c = new ClassroomCourse(102, "PCS4", 1, 20, 500);
            this.mySchool.AddCourse(c);
            this.mySchool.AddParticipantToCourse(102, 10, "Jansen");
            c = new ClassroomCourse(90, "PCS1", 80, 300, 1200);
            this.ShowAllCourses();
        }

        private void ShowAllCourses()
        {
            this.lbCourseOverview.Items.Clear();
            foreach (Course c in this.mySchool.GetAllCourses())
                this.lbCourseOverview.Items.Add(c);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(this.tbCourseId.Text);
            String courseName = this.tbCourseName.Text;
            int totalPrice = Convert.ToInt32(this.tbTotalPrice.Text);
            if (this.rbClassroomCourse.Checked)
            {
                // Add a classroom course
                int min = Convert.ToInt32(this.tbMinNrPart.Text);
                int max = Convert.ToInt32(this.tbMaxNrPart.Text);
                this.mySchool.AddCourse(new ClassroomCourse(courseId, courseName, min, max, totalPrice));
            }
            else
            {
                // Add an e-course
                this.mySchool.AddCourse(new ECourse(courseId, courseName, totalPrice));
            }
            this.ShowAllCourses();
        }

        private void btnOverviewAll_Click(object sender, EventArgs e)
        {
            this.ShowAllCourses();
        }

    }
}
