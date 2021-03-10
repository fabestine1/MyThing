using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._2
{
    public partial class Form1 : Form
    {
        private Student myStudent;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                myStudent = new Student(tbxName.Text, Convert.ToInt32(tbxStudentNumber.Text));
                Text = "Marks of " + myStudent.Name + " (" + myStudent.StNumber + ")";
            }
            catch (FormatException)
            {
                MessageBox.Show("The input format for name and/or student number is incorrect!");
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                myStudent.AddMark(Convert.ToInt32(tbxMark.Text));
                lbxMarks.Items.Add(tbxMark.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The input format for mark is incorrect!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to create a student first!");
            }
            catch (MarkOutOfRangeException my)
            {
                MessageBox.Show(my.Message);
            }
        }

        private void btnCalculateAverageMark_Click(object sender, EventArgs e)
        {
            try
            {
                lblAverageMarkResult.Text = myStudent.CalculateAverageMark().ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have to enter marks!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to create a student first!");
            }
        }
    }
}
