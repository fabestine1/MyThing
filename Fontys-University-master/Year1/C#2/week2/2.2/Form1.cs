using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2
{
    public partial class Form1 : Form
    {
        TrafficLight leftTrafficLight;
        TrafficLight rightTrafficLight;

        public Form1()
        {
            InitializeComponent();

            rightTrafficLight = new TrafficLight(20, "Red");

            leftTrafficLight = new TrafficLight(20, "Red");
        }

        private void bigger1_Click(object sender, EventArgs e)
        {
            leftTrafficLight.Size += 10;

            this.pbLeftTrafficLight.Invalidate();
        }

        private void smaller1_Click(object sender, EventArgs e)
        {
            leftTrafficLight.Size -= 10;

            this.pbLeftTrafficLight.Invalidate();
        }

        private void bigger2_Click(object sender, EventArgs e)
        {
            rightTrafficLight.Size += 10;

            this.pbRightTrafficLight.Invalidate();
        }

        private void smaller2_Click(object sender, EventArgs e)
        {
            rightTrafficLight.Size -= 10;

            this.pbRightTrafficLight.Invalidate();
        }

        private void changeColor1_Click(object sender, EventArgs e)
        {
            leftTrafficLight.ChangeColor();

            this.pbLeftTrafficLight.Invalidate();
        }

        private void changeColor2_Click(object sender, EventArgs e)
        {
            rightTrafficLight.ChangeColor();


            this.pbRightTrafficLight.Invalidate();
        }

        private void pbLeftTrafficLight_Paint(object sender, PaintEventArgs e)
        {
            leftTrafficLight.Draw(e.Graphics);
        }

        private void pbRightTrafficLight_Paint(object sender, PaintEventArgs e)
        {
            rightTrafficLight.Draw(e.Graphics);
        }
    }
}
