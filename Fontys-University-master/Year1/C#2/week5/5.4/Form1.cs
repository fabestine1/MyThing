using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._3
{
    public partial class Form1 : Form
    {
        Lottery game;

        int counter = 0;

        Random rnd;

        public Form1()
        {
            InitializeComponent();

            this.ilNumbers.ImageSize = new Size(256, 256);

            this.pbNumber.Image = this.ilNumbers.Images[100];

            rnd = new Random(5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int maxValue, maxDraw;

            if (int.TryParse(this.tbMaxValue.Text, out maxValue) && 
                int.TryParse(this.tbMaxDrawn.Text, out maxDraw))
            {
                game = new Lottery(maxValue, maxDraw);

                this.btnNext.Enabled = true;

                this.btnAll.Enabled = true;

                this.btnTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter integers");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (game.Ender)
            {
                this.tmRandom.Enabled = false;

                game.DrawNumber();

                this.lsbDrawnNumbers.Items.Add(game.DrawnNumbers[counter]);

                this.pbNumber.Image = this.ilNumbers.Images[game.DrawnNumbers[counter]];

                counter++;

                this.tmRandom.Interval = 3000;
                this.tmRandom.Enabled = true;
            }
            else
            {
                MessageBox.Show("All the numbers have been drawn");
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (game.Ender)
            {
                game.DrawAllNumbers();

                foreach (int i in game.DrawnNumbers)
                {
                    this.lsbDrawnNumbers.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("All the numbers have been drawn");
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            this.tmDraw.Enabled = !this.tmDraw.Enabled;
        }

        private void tmDraw_Tick(object sender, EventArgs e)
        {
            if (game.Ender)
            {
                game.DrawNumber();

                this.lsbDrawnNumbers.Items.Add(game.DrawnNumbers[counter]);

                this.pbNumber.Image = this.ilNumbers.Images[game.DrawnNumbers[counter]];

                counter++;
            }
            else
            {
                this.tmDraw.Stop();

                MessageBox.Show("All numbers have been drawn");
            }          
        }

        private void tmRandom_Tick(object sender, EventArgs e)
        {
            this.tmRandom.Interval = 100;

            if (counter < game.MaxDraw)
            { 
                int random = rnd.Next(1, 101);

                this.pbNumber.Image = this.ilNumbers.Images[random];
            }
            else
            {
                this.tmRandom.Enabled = false;
            }
        }
    }
}
