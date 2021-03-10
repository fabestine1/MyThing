using System;
using System.Windows.Forms;

namespace TicTacToe1
{
    public partial class Form1 : Form
    {

        // This variable keeps which player's turn it is
        // 1 = player1. 2 = player2
        int player = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Make a move
        /// </summary>
        /// <param name="button"></param>
        private void MakeMove(Button button)
        { 
            // Set player button to X or O
            if (player == 1)
                button.Text = "X";
            else
                button.Text = "O";

            button.Enabled = false;

            // Switch player turn
            if (player == 1)
            {
                player = 2;
                labelTurn.Text = textBoxPlayer2.Text;
            }
            else if (player == 2)
            {
                player = 1;
                labelTurn.Text = textBoxPlayer1.Text;
            }

            // Copy all text values to string variables
            // to make it easier to write
            string a1, a2, a3, b1, b2, b3, c1, c2, c3;
            a1 = button1.Text;
            a2 = button2.Text;
            a3 = button3.Text;
            b1 = button4.Text;
            b2 = button5.Text;
            b3 = button6.Text;
            c1 = button7.Text;
            c2 = button8.Text;
            c3 = button9.Text;

            // check if a user won.
            if (a1 == "X" && a2 == "X" && a3 == "X" ||
                b1 == "X" && b2 == "X" && b3 == "X" ||
                c1 == "X" && c2 == "X" && c3 == "X" ||
                a1 == "X" && b1 == "X" && c1 == "X" ||
                a2 == "X" && b2 == "X" && c2 == "X" ||
                a3 == "X" && b3 == "X" && c3 == "X" ||
                a1 == "X" && b2 == "X" && c3 == "X" ||
                a3 == "X" && b2 == "X" && c1 == "X")
            {
                labelResult.Text = textBoxPlayer1.Text + " won!";
            }
            if (a1 == "O" && a2 == "O" && a3 == "O" ||
                b1 == "O" && b2 == "O" && b3 == "O" ||
                c1 == "O" && c2 == "O" && c3 == "O" ||
                a1 == "O" && b1 == "O" && c1 == "O" ||
                a2 == "O" && b2 == "O" && c2 == "O" ||
                a3 == "O" && b3 == "O" && c3 == "O" ||
                a1 == "O" && b2 == "O" && c3 == "O" ||
                a3 == "O" && b2 == "O" && c1 == "O")
            {
                labelResult.Text = textBoxPlayer2.Text + " won!";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeMove(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeMove(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeMove(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeMove(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MakeMove(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MakeMove(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MakeMove(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MakeMove(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MakeMove(button9);
        }

        private void textBoxPlayer1_TextChanged(object sender, EventArgs e)
        {
            labelTurn.Text = textBoxPlayer1.Text;
        }
    }
}
