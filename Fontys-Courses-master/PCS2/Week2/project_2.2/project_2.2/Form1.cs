using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._2
{
    public partial class Form1 : Form
    {
        TrafficLight trafficlight1 = new TrafficLight(20, Color.Red, 150);
        TrafficLight trafficlight2 = new TrafficLight(50, Color.Green, 300);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            trafficlight1.Size = 75;
            Refresh();
        }

        private void pbTrafficLight_Paint(object sender, PaintEventArgs e)
        {
            trafficlight1.Draw(e.Graphics);
        }

        private void pbTrafficLight2_Paint(object sender, PaintEventArgs e)
        {
            trafficlight2.Draw(e.Graphics);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (timerTrafficLightLeft.Enabled)
            {
                timerTrafficLightLeft.Stop();
                btnStart.Text = "START";
            }
            else
            {
                timerTrafficLightLeft.Start();
                timerTrafficLightLeft.Interval = trafficlight1.TimeInterval;
                btnStart.Text = "STOP";
            }
        }

        private void btnChangeColor2_Click(object sender, EventArgs e)
        {
            if (timerTrafficLightRight.Enabled)
            {
                timerTrafficLightRight.Stop();
                btnStart2.Text = "START";
            }
            else
            {
                timerTrafficLightRight.Start();
                timerTrafficLightRight.Interval = trafficlight2.TimeInterval;
                btnStart2.Text = "STOP";
            }
        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            trafficlight1.Size = 5;
            Refresh();
        }

        private void btnBigger2_Click(object sender, EventArgs e)
        {
            trafficlight2.Size = 75;
            Refresh();
        }

        private void btnSmaller2_Click(object sender, EventArgs e)
        {
            trafficlight2.Size = 5;
            Refresh();
        }

        private void timerTrafficLightLeft_Tick(object sender, EventArgs e)
        {
            trafficlight1.ChangeColor();
            Refresh();
        }

        private void timerTrafficLightRight_Tick(object sender, EventArgs e)
        {
            trafficlight2.ChangeColor();
            Refresh();
        }

        private void btnStartSync_Click(object sender, EventArgs e)
        {
            if (timerSync.Enabled)
            {
                timerSync.Stop();
                btnStartSync.Text = "START";
            }
            else
            {
                timerSync.Start();
                timerSync.Interval = trafficlight1.TimeInterval;
                btnStartSync.Text = "STOP";
            }
        }

        private void timerSync_Tick(object sender, EventArgs e)
        {
            trafficlight1.ChangeColor();
            trafficlight2.ChangeColor();
            Refresh();
        }
    }
}
