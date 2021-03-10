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

        public Form1()
        {
            InitializeComponent();
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
                game.DrawNumber();

                this.lsbDrawnNumbers.Items.Add(game.DrawnNumbers[counter]);

                counter++;
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

                for (int i = 0; i < game.MaxDraw; i++)
                {
                    this.lsbDrawnNumbers.Items.Add(game.DrawnNumbers[i]);
                }
            }
            else
            {
                MessageBox.Show("All the numbers have been drawn");
            }
        }
    }
}
