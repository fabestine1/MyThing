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

        // constructor
        public Form1()
        {
            InitializeComponent();
            this.mySchool = new School("Fontys ICT");
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
            if (lbCourseOverview.SelectedItem != null)
            {
                try
                {
                    int id = Convert.ToInt32(tbParticipantId.Text);
                    String name = tbParticipantName.Text.ToString();
                    Course c = (Course)lbCourseOverview.SelectedItem;
                    c.AddParticipant(id, name);
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
            this.lbCourseOverview.Items.Clear();
            foreach (var course in this.mySchool.GetAllCourses())
            {
                if (course is ClassroomCourse)
                {
                    if (((ClassroomCourse)course).WillTakePlace())
                    {
                        this.lbCourseOverview.Items.Add(course.ToString());
                    }
                }
                else
                {
                    this.lbCourseOverview.Items.Add(course.ToString());
                }
            }
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
            int totalE = 0;
            int totalC = 0;
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream("../../revenue.txt", FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine("Course overview of school " + this.mySchool.GetName());
                streamWriter.WriteLine("***** e-courses *****");
                foreach (var courses in this.mySchool.GetAllCourses())
                {
                    if (courses is ECourse)
                    {
                        streamWriter.WriteLine(courses.ToString());
                        totalE += courses.GetPricePerParticipant() * courses.GetNrOfParticipants();
                    }
                }
                streamWriter.WriteLine("***** e-courses *****");
                foreach (var courses in this.mySchool.GetAllCourses())
                {
                    if (courses is ClassroomCourse)
                    {
                        if (((ClassroomCourse) courses).WillTakePlace())
                        {
                            streamWriter.WriteLine(courses.ToString());
                            totalC += courses.GetPricePerParticipant() * courses.GetNrOfParticipants();
                        }
                    }
                }
                streamWriter.WriteLine("***** revenues  *****");

                streamWriter.WriteLine("The total revenue for E-courses is: " + totalE);
                streamWriter.WriteLine("The total revenue for Classroom courses is: " + totalC);
            }
            catch (IOException)
            {
                MessageBox.Show("Something wrong with saving to file");
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
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
