using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        SecretCombi sc;
        private int score1 = 0;
        private int score2 = 0;
        private int counter = 0;
        private int credits = 100;
        private bool newGame;
        public Form1()
        {
            InitializeComponent();
            sc = new SecretCombi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                int number1 = Convert.ToInt32(textBox1.Text);
                int number2 = Convert.ToInt32(textBox2.Text);
                int number3 = Convert.ToInt32(textBox3.Text);
                int number4 = Convert.ToInt32(textBox4.Text);
                if (number1 > 0 && number1 < 10 && number2 > 0 && number2 < 10 && number3 > 0 && number3 < 10 && number4 > 0 && number4 < 10)
                {
                    int[] guess = new int[4] { number1, number2, number3, number4 };
                    if (guess.Length != guess.Distinct().Count())
                    {
                        MessageBox.Show("All numbers must be unique.");
                    }
                    else
                    {
                        if (newGame)
                        {
                            counter = 0;
                            credits = 100;
                            listBox1.Items.Clear();
                            newGame = false;
                        }
                        counter++;
                        int[] combination = sc.CheckGuess(guess, out score1, out score2, ref credits);
                        listBox1.Items.Add(number1 + "," + number2 + "," + number3 + "," + number4 + ":\tSCORE-1:  " + score1 + "\tSCORE-2:  " + score2);
                        if (score1 == 4)
                        {
                            MessageBox.Show("You won! You found the 4 secret numbers!");
                        }
                        else if (counter == 10)
                        {
                            MessageBox.Show("You lost. You have tried 10 times and not found the secret combination.\nThe secreat combination is: " + combination[0] + "," + combination[1] + "," + combination[2] + "," + combination[3] + "\nYou have " + credits + " credits.");
                        }
                        if (score1 == 4 || counter == 10)
                        {
                            sc = new SecretCombi();
                            newGame = true;
                        }
                        }
                    }
                else
                {
                    MessageBox.Show("All number must be between 1 and 9 inclusively.");
                }
            }
            else
            {
                MessageBox.Show("You have to fill in the 4 numbers.");
            }
        }
    }
}