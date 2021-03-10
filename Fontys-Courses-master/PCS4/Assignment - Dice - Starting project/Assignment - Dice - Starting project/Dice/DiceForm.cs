using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dobbelsteen
{
    public partial class DiceForm : Form
    {
        Random rnd;
        bool[] generatedNumber;
        int nr;
        public DiceForm()
        {
            InitializeComponent();
            rnd = new Random();
            generatedNumber = new bool[6];
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            nr = rnd.Next(1, 7);
            while(generatedNumber[nr - 1] == true)
            {
                if (generatedNumber[0] == true && generatedNumber[1] == true && generatedNumber[2] == true && generatedNumber[3] == true && generatedNumber[4] == true && generatedNumber[5] == true)
                {
                    break;
                }
                else
                {
                    nr = rnd.Next(1, 7);
                }
            }
            if (!generatedNumber[nr - 1])
            {
                generatedNumber[nr - 1] = true;
            }

            if (nr == 1)
            {
                number1PictureBox.Visible = true;
            }
            else if (nr == 2)
            {
                number2PictureBox.Visible = true;
            }
            else if (nr == 3)
            {
                number3PictureBox.Visible = true;
            }
            else if (nr == 4)
            {
                number4PictureBox.Visible = true;
            }
            else if (nr == 5)
            {
                number5PictureBox.Visible = true;
            }
            else if (nr == 6)
            {
                number6PictureBox.Visible = true;
            }
        }
    }
}
