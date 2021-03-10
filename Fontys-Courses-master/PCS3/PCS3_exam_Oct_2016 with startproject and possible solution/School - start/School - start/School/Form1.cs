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
        // fields
        private School mySchool;
        private String schoolName = "Fontys ICT";

        // constructor
        public Form1()
        {
            InitializeComponent();
            this.mySchool = new School(schoolName);
            this.AddSomeCoursesForTestPurpose();
        }
 
        // methods

        ////////////////////////// BEGIN YOUR CODE HERE ///////////////////////////////

        /// <summary>
        /// btnAddParticipant_Click(object sender, EventArgs e)
        /// Button event handler to add a participant with the specified data 
        /// to the course that is currently selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            // To do, assignment 4
            try
            {
                mySchool.AddParticipantToCourse(((Course)lbCourseOverview.SelectedItem).CourseId, Convert.ToInt32(tbParticipantId.Text), tbParticipantName.Text);
                ShowAllCourses();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to select a course.");
            }
            catch (FormatException)
            {
                MessageBox.Show("The format of the participant ID and/or name is incorrect.");
            }
            catch (CourseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// btnOverviewAllThatTakePlace_Click(object sender, EventArgs e)
        /// Button event handler to display an overview of all courses that take place
        /// in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOverviewAllThatTakePlace_Click(object sender, EventArgs e)
        {
            // To do, assignment 5
            lbCourseOverview.Items.Clear();
            foreach(Course c in CoursesWillTakePlace())
            {
                lbCourseOverview.Items.Add(c);
            }
        }

        private List<Course> CoursesWillTakePlace()
        {
            List<Course> temp = new List<Course>();
            foreach (Course c in mySchool.GetAllCourses())
            {
                if (c is ClassroomCourse)
                {
                    if (((ClassroomCourse)c).WillTakePlace())
                    {
                        temp.Add(c);
                    }
                }
                else
                {
                    temp.Add(c);
                }
            }
            return temp;
        }

        /// <summary>
        /// btnSaveOverview_Click(object sender, EventArgs e)
        /// Button event handler to save an overview of all courses that take place
        /// and the total revenue for both types of courses in a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOverview_Click(object sender, EventArgs e)
        {
            // To do, assignment 6
            FileStream fs;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("overview.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(schoolName);
                double[] revenues = new double[2];
                sw.WriteLine("***** e-courses *****");
                foreach (Course c in CoursesWillTakePlace())
                {
                    if(c is ECourse)
                    {
                        sw.WriteLine(c.ToString());
                        revenues[0] += ((ECourse)c).GetPricePerParticipant() * c.GetNrOfParticipants();
                    }
                }
                sw.WriteLine("***** classroom courses *****");
                foreach (Course c in CoursesWillTakePlace())
                {
                    if (c is ClassroomCourse)
                    {
                        sw.WriteLine(c.ToString());
                        revenues[1] += ((ClassroomCourse)c).GetPricePerParticipant() * c.GetNrOfParticipants();
                    }
                }
                sw.WriteLine("***** revenues *****");
                sw.WriteLine("Total revenue of all E-Courses: " + revenues[0]);
                sw.WriteLine("Total revenue of all Classroom courses that will take place: " + revenues[1]);
            }
            catch (IOException ex)
            {
                MessageBox.Show("There was an error writing to file: " + ex.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }

        ////////////////////////// END YOUR CODE HERE ///////////////////////////////

        /// <summary>
        /// AddSomeCoursesForTestPurpose()
        /// Adds some courses to mySchool for testing purposes
        /// </summary>
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

        /// <summary>
        /// ShowAllCourses()
        /// Clears the listbox and fills it with all courses of mySchool
        /// </summary>
        private void ShowAllCourses()
        {
            this.lbCourseOverview.Items.Clear();
            foreach (Course c in this.mySchool.GetAllCourses())
                this.lbCourseOverview.Items.Add(c);
        }

        /// <summary>
        /// btnAddCourse_Click(object sender, EventArgs e)
        /// Button event handler to add a course to mySchool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// btnOverviewAll_Click(object sender, EventArgs e)
        /// Button event handler to display an overview of all courses in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOverviewAll_Click(object sender, EventArgs e)
        {
            this.ShowAllCourses();
        }

    }
}
