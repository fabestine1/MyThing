using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4._1
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int result;
        public Form1()
        {
            InitializeComponent();

        }
        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(tbFirstNumber.Text);
                y = Convert.ToInt32(tbSecondNumber.Text);

                result = x + y;

                lbOutput.Items.Add(result);
            }
            catch (FormatException) { lbOutput.Items.Add("Enter a number!"); }
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(tbFirstNumber.Text);
                y = Convert.ToInt32(tbSecondNumber.Text);
                result = x - y;
                lbOutput.Items.Add(result);

            }
            catch(FormatException) { lbOutput.Items.Add("Enter a number!"); }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(tbFirstNumber.Text);
                y = Convert.ToInt32(tbSecondNumber.Text);
                result = x * y;
                lbOutput.Items.Add(result);

            }
            catch (FormatException) { lbOutput.Items.Add("Enter a number!"); }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(tbFirstNumber.Text);
                y = Convert.ToInt32(tbSecondNumber.Text);
                result = x / y;
                lbOutput.Items.Add(result);
            }
            catch (FormatException) { lbOutput.Items.Add("Enter a number!"); }
            catch (DivideByZeroException) { lbOutput.Items.Add("You cannot divide by 0!"); }
        }
    }
}
