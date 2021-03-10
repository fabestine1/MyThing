using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_2
{
    public partial class Form1 : Form
    {
        int seconds = 1000;

        Random rnd;

        enum result
        {
            Heads,
            Tails
        };

        public Form1()
        {
            InitializeComponent();

            rnd = new Random();   
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            int random = rnd.Next(0, 2);

            result heads = result.Heads;
            result tails = result.Tails;

            if (random == (int)heads)
            {
                this.pbFirstCoin.Visible = true;

                this.lbResult.Text = "Heads";
            }
            else if (random == (int)tails)
            {
                this.pbSecondCoin.Visible = true;

                this.lbResult.Text = "Tails";
            }

            this.tmChange.Enabled = true;
        }

        private void tmChange_Tick(object sender, EventArgs e)
        {
            this.tmChange.Interval = seconds;
 
            if (this.pbFirstCoin.Visible)
            {
                this.pbFirstCoin.Visible = false;

                this.pbSecondCoin.Visible = true;

                this.lbResult.Text = "Tails";
            }
            else if (this.pbSecondCoin.Visible)
            {
                this.pbSecondCoin.Visible = false;

                this.pbFirstCoin.Visible = true;

                this.lbResult.Text = "Heads";
            }

            seconds -= 50;

            if(seconds <= 50)
            {
                this.tmChange.Stop();

                this.tmChange.Enabled = false;

                MessageBox.Show("The result is: " + this.lbResult.Text);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.pbFirstCoin.Visible = false;

            this.pbSecondCoin.Visible = false;

            this.lbResult.Text = "";

            seconds = 1000;

            this.tmChange.Interval = seconds;
        }
    }
}
