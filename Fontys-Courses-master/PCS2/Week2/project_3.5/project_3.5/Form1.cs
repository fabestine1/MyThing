using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Diagonal(double length, double breadth)
        {
            return Math.Sqrt(length * length + breadth * breadth);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Diagonal(Convert.ToDouble(tbxLength.Text), Convert.ToDouble(tbxBreadth.Text)));
        }
    }
}
