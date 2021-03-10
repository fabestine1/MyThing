using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._4
{
    public partial class Form1 : Form
    {
        int[] counter = new int[5];

        int newAverage, counterA = 0, counterB = 0, counterC = 0, counterD = 0, counterE = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newAverage = int.Parse(this.tbAverage.Text);

            if(newAverage <= 100 && newAverage > 90)
            {
                counterA++;
            }
            else if(newAverage <= 90 && newAverage > 80)
            {
                counterB++;
            }
            else if(newAverage <= 80 && newAverage > 70)
            {
                counterC++;
            }
            else if(newAverage <= 70 && newAverage > 60)
            {
                counterD++;
            }
            else if(newAverage <= 60 && newAverage >= 0)
            {
                counterE++;
            }

            counter[0] = counterA;
            counter[1] = counterB;
            counter[2] = counterC;
            counter[3] = counterD;
            counter[4] = counterE;

            this.tbA.Text = counter[0].ToString();
            this.tbB.Text = counter[1].ToString();
            this.tbC.Text = counter[2].ToString();
            this.tbD.Text = counter[3].ToString();
            this.tbE.Text = counter[4].ToString();
        }
    }
}
