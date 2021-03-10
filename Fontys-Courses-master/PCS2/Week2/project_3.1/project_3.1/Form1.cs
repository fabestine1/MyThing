using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3._1
{
    public partial class Form1 : Form
    {
        int c;
        public Form1()
        {
            InitializeComponent();
            c = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundTimer.Enabled == false)
            {
                backgroundTimer.Start();
            }
            else
            {
                backgroundTimer.Stop();
            }
        }

        private void backgroundTimer_Tick(object sender, EventArgs e)
        {
                c += 50;
                if (c >= 255)
                {
                    c = 0;
                }
                this.BackColor = Color.FromArgb(c, 255 - c, c);
                if (backgroundTimer.Interval - 100 >= 1)
                {
                    backgroundTimer.Interval -= 100;
                }
                Application.DoEvents();
        }
    }
}
