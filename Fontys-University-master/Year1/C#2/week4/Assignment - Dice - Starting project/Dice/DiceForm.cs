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
        public DiceForm()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            number1PictureBox.Visible = false;
            number2PictureBox.Visible = false;
            number3PictureBox.Visible = false;
            number4PictureBox.Visible = false;
            number5PictureBox.Visible = false;
            number6PictureBox.Visible = false;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int number = rnd.Next(1, 7);

            switch(number)
            {
                case 1:
                    number1PictureBox.Visible = true;
                    break;
                case 2:
                    number2PictureBox.Visible = true;
                    break;
                case 3:
                    number3PictureBox.Visible = true;
                    break;
                case 4:
                    number4PictureBox.Visible = true;
                    break;
                case 5:
                    number5PictureBox.Visible = true;
                    break;
                case 6:
                    number6PictureBox.Visible = true;
                    break;
            }
        }
    }
}
