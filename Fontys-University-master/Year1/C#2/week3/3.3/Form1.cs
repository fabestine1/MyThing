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
        bool checker = true;

        public Form1()
        {
            InitializeComponent();

            rightTrafficLight = new TrafficLight(20, "Green");

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

        private void btnTurnOnTimerLeft_Click(object sender, EventArgs e)
        {
            if (this.tmLeftTraficLight.Enabled == false)
            {
                this.tmLeftTraficLight.Enabled = true;
                this.btnTurnOnTimerLeft.Text = "Turn Off Timer";
            }
            else
            {
                this.tmLeftTraficLight.Enabled = false;
                this.btnTurnOnTimerLeft.Text = "Turn On Timer";
            }
        }

        private void btnTurnOnTimerRight_Click(object sender, EventArgs e)
        {
            if (this.tmRightTraficLight.Enabled == false)
            {
                this.tmRightTraficLight.Enabled = true;
                this.btnTurnOnTimerRight.Text = "Turn Off Timer";
            }
            else
            {
                this.tmRightTraficLight.Enabled = false;
                this.btnTurnOnTimerRight.Text = "Turn On Timer";
            }
        }

        private void tmLeftTraficLight_Tick(object sender, EventArgs e)
        {
            leftTrafficLight.ChangeColor();

            this.pbLeftTrafficLight.Invalidate();
        }

        private void tmRightTraficLight_Tick(object sender, EventArgs e)
        {
            rightTrafficLight.ChangeColor();

            this.pbRightTrafficLight.Invalidate();
        }

        private void btnTurnOnSimultaneously_Click(object sender, EventArgs e)
        {
            if (this.tmSimultaneously.Enabled == false)
            {
                this.tmSimultaneously.Enabled = true;
                this.btnTurnOnSimultaneously.Text = "Turn Off";
            }
            else
            {
                this.tmSimultaneously.Enabled = false;
                this.btnTurnOnSimultaneously.Text = "Turn on Simultaneously";
            }
        }

        private void tmSimultaneously_Tick(object sender, EventArgs e)
        {
            if (leftTrafficLight.Color == "Red" && checker)
            {
                rightTrafficLight.ChangeColor();

                this.pbRightTrafficLight.Invalidate();

                if (rightTrafficLight.Color == "Red")
                {
                    checker = !checker;
                }
            }
            else if (rightTrafficLight.Color == "Red" && checker == false)
            {
                leftTrafficLight.ChangeColor();

                this.pbLeftTrafficLight.Invalidate();

                if (leftTrafficLight.Color == "Red")
                {
                    checker = !checker;
                }
            }

            if(rightTrafficLight.Color == "Green" || leftTrafficLight.Color == "Green")
            {
                this.tmSimultaneously.Interval = 10000;
            }
            else if (rightTrafficLight.Color == "Orange" || leftTrafficLight.Color == "Orange")
            {
                this.tmSimultaneously.Interval = 1000;
            }
        }
    }
}