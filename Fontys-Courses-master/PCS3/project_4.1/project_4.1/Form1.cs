using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try {
                richTextBoxResult.Text += tbxNumberA.Text + " + " + tbxNumberB.Text + " = " + (Convert.ToInt32(tbxNumberA.Text) + Convert.ToInt32(tbxNumberB.Text)) + "\n";
            }
            catch (FormatException)
            {
                richTextBoxResult.Text += "Please enter integer numbers!\n";
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Text += tbxNumberA.Text + " - " + tbxNumberB.Text + " = " + (Convert.ToInt32(tbxNumberA.Text) - Convert.ToInt32(tbxNumberB.Text) + "\n");
            }
            catch (FormatException)
            {
                richTextBoxResult.Text += "Please enter integer numbers!\n";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Text += tbxNumberA.Text + " / " + tbxNumberB.Text + " = " + (Convert.ToInt32(tbxNumberA.Text) / Convert.ToInt32(tbxNumberB.Text) + "\n");
            }
            catch (FormatException)
            {
                richTextBoxResult.Text += "Please enter integer numbers!\n";
            }
            catch (DivideByZeroException)
            {
                richTextBoxResult.Text += "Number 2 cannot be zero when you divide!\n";
            }
        }

        private void btnMiltiply_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Text += tbxNumberA.Text + " * " + tbxNumberB.Text + " = " + (Convert.ToInt32(tbxNumberA.Text) * Convert.ToInt32(tbxNumberB.Text) + "\n");
            }
            catch (FormatException)
            {
                richTextBoxResult.Text += "Please enter integer numbers!\n";
            }
        }
    }
}
