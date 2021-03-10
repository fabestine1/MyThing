using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._6
{
    public partial class Form1 : Form
    {
        int[] first = new int[5];
        int[] second = new int[5];
        int[] third = new int[5];

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < 5; i++)
            {
                first[i] = rnd.Next(1, 7);
                second[i] = rnd.Next(1, 7);

                this.lbNumbersArr1.Text += first[i] + " ";

                this.lbNumbersArr2.Text += second[i] + " ";
            }
        }

        private void btnThrid_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                if(first[i] == second[i])
                {
                    third[i] = 1;
                }

                this.lbNumbersArr3.Text += third[i] + " ";
            }

            this.lbThirdArray.Visible = true;
        }
    }
}
