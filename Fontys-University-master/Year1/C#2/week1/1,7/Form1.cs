using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            int booksPurchased, points = 0;

            booksPurchased = int.Parse(this.tBooksPurchased.Text);

            if (booksPurchased == 0)
            {
                points = 0;
            }
            else if (booksPurchased == 1)
            {
                points = 5;
            }
            else if (booksPurchased == 2)
            {
                points = 15;
            }
            else if (booksPurchased == 3)
            {
                points = 30;
            }
            else if (booksPurchased >= 4)
            {
                points = 60;
            }

            this.tPoints.Text = points.ToString();
        }
    }
}
