using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._5
{
    public partial class GuessTheNumber : Form
    {
        Random rnd;
        int number;

        public GuessTheNumber()
        {
            InitializeComponent();
            rnd = new Random();

            number = rnd.Next(1, 1000);
        }

        private void tbGuess_TextChanged(object sender, EventArgs e)
        {
            int guess;

            if (Int32.TryParse(this.tbGuess.Text, out guess))
            {
                if(guess == number || guess == 0)
                {
                    this.lbHelper.Text = "Correct";

                    this.BackColor = Color.Lime;

                    this.tbGuess.Enabled = false;
                }
                else if(guess >= number - 50 && guess <= number + 50)
                {
                    this.lbHelper.Text = "Warm";

                    this.BackColor = Color.Red;
                }
                else
                {
                    this.lbHelper.Text = "Cold";

                    this.BackColor = Color.Blue;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            number = rnd.Next(1, 1000);

            this.lbHelper.Text = "";

            this.tbGuess.Text = "";

            this.tbGuess.Enabled = true;

            this.BackColor = Color.Honeydew;
        }
    }
}
