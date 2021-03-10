using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5
{
    public partial class Form1 : Form
    {
        double milesPerGallon;

        public Form1()
        {
            InitializeComponent();
        }

        private void town_CheckedChanged(object sender, EventArgs e)
        {
            milesPerGallon = 21.5;
        }

        private void highway_CheckedChanged(object sender, EventArgs e)
        {
            milesPerGallon = 26.8;
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            double gallons, miles;

            gallons = double.Parse(this.tGallons.Text);

            miles = milesPerGallon * gallons;

            this.tMiles.Text = miles.ToString("0.00");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
