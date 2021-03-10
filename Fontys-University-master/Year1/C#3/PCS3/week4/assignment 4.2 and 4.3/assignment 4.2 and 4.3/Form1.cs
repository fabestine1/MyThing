using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4._2_and_4._3
{
    public partial class Form1 : Form
    {
        Student myStudent;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                myStudent = new Student(tbName.Text, Convert.ToInt32(tbStudentNumber.Text));
            }
            catch (FormatException) { MessageBox.Show("Enter something!"); }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            try
            {
                labelAvg.Text = Convert.ToString(myStudent.CalculateAverageMark());
            }
            catch (NullReferenceException) { MessageBox.Show("Try again!"); }
        }

        private void btnAddMark_Click_1(object sender, EventArgs e)
        {
            try
            {
                myStudent.AddMark(Convert.ToInt32(tbNewMark.Text));
                listBox1.Items.Add(Convert.ToInt32(tbNewMark.Text));
            }
            catch (FormatException) { MessageBox.Show("Enter something!"); }
            catch (NoNullAllowedException) { MessageBox.Show("Try again!"); }
            catch (MarkOutOfRangeException) { MessageBox.Show("Mark out of range!"); }
        }
    }
}

