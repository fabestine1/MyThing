using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._5
{
    public partial class Form1 : Form
    {
        Random rnd;
        int number;
        int lastGuess;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start" || btnStart.Text == "Play again") {
                number = rnd.Next(0, 1001);
                BackColor = DefaultBackColor;
                if(btnStart.Text == "Start")
                {
                    tbxGuessNumber.Visible = true;
                    btnStart.Text = "Try";
                }
                tbxGuessNumber.Enabled = true;
            }
            if (lblQuestionCaption.Text == "")
            {
                lblQuestionCaption.Text = "I have a number between 1 and 1000 -- can you guess my number? Please enter your first guess.";
            }
            else
            {
                btnStart.Text = "Try again";
                if (lastGuess != 0) {
                lblQuestionCaption.ForeColor = Color.White;
                }
                if (tbxGuessNumber.Text == number.ToString())
                {
                    MessageBox.Show("Correct!");
                    BackColor = Color.Green;
                    tbxGuessNumber.Enabled = false;
                    btnStart.Text = "Play again";
                    lblQuestionCaption.Text = "";
                }
                else if (Convert.ToInt32(tbxGuessNumber.Text) - number > 0) {
                    lblQuestionCaption.Text = "Too High";
                }
                else
                {
                    lblQuestionCaption.Text = "Too Low";
                }
                    if (Convert.ToInt32(tbxGuessNumber.Text) - number > lastGuess - number)
                    {
                        if (BackColor != Color.Blue)
                        {
                            BackColor = Color.Blue;
                        }
                    }
                    else
                    {
                        if (BackColor != Color.Red)
                        {
                            BackColor = Color.Red;
                        }
                    }
                lastGuess = Convert.ToInt32(tbxGuessNumber.Text);
            }
        }
    }
}
