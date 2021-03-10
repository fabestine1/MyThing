using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationDemo
{
    public partial class Form1 : Form
    {
        private Car car;
        private Bicycle bike;
        private Boat boat;

        public Form1()
        {
            InitializeComponent();
            car = new Car("TUPOMIE", Color.AliceBlue, 65);
            bike = new Bicycle(true, 20);
            boat = new Boat("QKATARABOTA", 1150, 30);
        }

        private void BicycleBttn_Click(object sender, EventArgs e)
        {
            bikeLbl.Text = bike.GetInfo();
        }

        private void CarBttn_Click(object sender, EventArgs e)
        {
            carLbl.Text = car.GetInfo();
        }

        private void BoatBttn_Click(object sender, EventArgs e)
        {
            boatLbl.Text = boat.GetInfo();
        }
    }
}
