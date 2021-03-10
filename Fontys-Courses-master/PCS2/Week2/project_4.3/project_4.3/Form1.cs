using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._3
{
    public partial class Form1 : Form
    {
        Lottery lotto;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLotteryObject_Click(object sender, EventArgs e)
        {
            lotto = new Lottery(Convert.ToInt32(tbxMaxValue.Text), Convert.ToInt32(tbxNrWanted.Text));
            btnDrawNextNumber.Enabled = true;
            btnDrawAllNumbers.Enabled = true;
            btnShowInfo.Visible = true;
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string isOver;
            lbxInfo.Visible = true;
            if (lotto.DrawingIsOver)
            {
                isOver = "Drawing is over.";
            }
            else
            {
                isOver = "Drawing is not over.";
            }
            lbxInfo.Items.Add("Maximum number: " + lotto.MaxValue);
            lbxInfo.Items.Add("Number of wanted numbers: " + lotto.NrOfWantedNumbers);
            lbxInfo.Items.Add("Number of drawn numbers: " + lotto.NrOfDrawnNumbers);
            lbxInfo.Items.Add(isOver);
        }

        private void btnDrawNextNumber_Click(object sender, EventArgs e)
        {
            lotto.Draw1Number();
        }

        private void btnDrawAllNumbers_Click(object sender, EventArgs e)
        {
            lotto.DrawAllNumbers();
        }

        private void btnFlashyAnimation_Click(object sender, EventArgs e)
        {
            lotto = new Lottery(Convert.ToInt32(tbxMaxValue.Text), Convert.ToInt32(tbxNrWanted.Text));
            btnDrawNextNumber.Enabled = true;
            btnDrawAllNumbers.Enabled = true;
            btnShowInfo.Visible = true;
            timerFlashy.Start();
        }

        private void timerFlashy_Tick(object sender, EventArgs e)
        {
            if (counter < 6)
            {
                lbxInfo.Visible = true;
                //string numberImage;
                lotto.Draw1Number();
                //if (lotto.GetLastNumberDrawn() < 10)
                //{
                //    numberImage = Convert.ToString(0) + lotto.GetLastNumberDrawn();
                //}
                //else
                //{
                //    numberImage = lotto.GetLastNumberDrawn().ToString();
                //}
                //pbxNumber.ImageLocation = "images/P" + numberImage + ".png";
                pbxNumber.Image = imageList1.Images[lotto.GetLastNumberDrawn()];
                lbxInfo.Items.Add(lotto.GetLastNumberDrawn());
                counter++;
            }
            else
            {
                timerFlashy.Stop();
                lbxInfo.Items.Add("Drawing is over.");
            }
        }
    }
}
