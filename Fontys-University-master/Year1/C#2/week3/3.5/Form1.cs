using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._5
{
    public partial class Form1 : Form
    {
        public double FindDiagonal(double lenght, double breadth)
        {
            double diagonal;

            diagonal = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(breadth, 2));

            return diagonal;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length, breadth, diagonal;

            length = double.Parse(this.tbLength.Text);
            breadth = double.Parse(this.tbBreadth.Text);

            diagonal = FindDiagonal(length, breadth);

            this.tbDiagonal.Text = diagonal.ToString("#.##");
        }
    }
}
