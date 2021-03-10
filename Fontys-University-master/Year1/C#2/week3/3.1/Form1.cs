using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _3._1
{
    public partial class Color : Form
    {
        bool checker = false;

        public Color()
        {
            InitializeComponent();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            int time = 100;

            if(checker == false)
            {
                checker = true;
            }
            else
            {
                checker = false;
            }

            while(checker == true)
            {
                System.Threading.Thread.Sleep(time);

                time+=1000;

                if (checker == true)
                {
                    Random color = new Random();
                    int red = color.Next(0, 225);
                    int green = color.Next(0, 225);
                    int blue = color.Next(0, 225);

                    this.BackColor = System.Drawing.Color.FromArgb(red, green, blue);

                    Application.DoEvents();
                }
            }
        }

        
    }
}
