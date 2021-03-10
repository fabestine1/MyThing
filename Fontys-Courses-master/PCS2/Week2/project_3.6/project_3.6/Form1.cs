using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3._6
{
    public partial class Form1 : Form
    {
        private Car mycar1;
        private Car mycar2;
        private Car currentSelectedCar;
        public Form1()
        {
            InitializeComponent();
            mycar1 = new Car("Acura", 25267, 2578);
            mycar2 = new Car("Alfa Romeo", 59562, 5926);
        }
        private void rbtnPrivateCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrivateCar.Checked)
            {
                currentSelectedCar = mycar1;
            }
            pbCar.ImageLocation = "images/2018-Acura-RLX-101.jpg";
            lblBrand.Text = mycar1.Brand;
            lblMileage.Text = mycar1.LatestMileage.ToString();
        }
        private void rbtnBusinessCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBusinessCar.Checked)
            {
                currentSelectedCar = mycar2;
            }
            pbCar.ImageLocation = "images/2018-Alfa-Romeo-Stelvio-Quadrifoglio-306.jpg";
            lblBrand.Text = mycar2.Brand;
            lblMileage.Text = mycar2.LatestMileage.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(udLitersTanked.Value < 0)
            {
                MessageBox.Show("Liters tanked cannot be negative!");
            }
            else if (Convert.ToInt32(tbxLitersLeft.Text) < 0)
            {
                MessageBox.Show("Liters in car cannot be negative!");
            }
            else if (currentSelectedCar.LatestMileage >= Convert.ToInt32(tbxTotalMileage.Text))
            {
                MessageBox.Show("New mileage is not greater than the mileage at the former refueling stop!");
            }
            else
            {
                currentSelectedCar.UpdateCar(Convert.ToInt32(tbxLitersLeft.Text), Convert.ToInt32(udLitersTanked.Value), Convert.ToInt32(tbxTotalMileage.Text));
            }
        }

        private void btnShowFuelEfficiency_Click(object sender, EventArgs e)
        {
            lblKmPerLiter.Text = currentSelectedCar.GetFuelEfficiency().ToString();
        }
    }
}
