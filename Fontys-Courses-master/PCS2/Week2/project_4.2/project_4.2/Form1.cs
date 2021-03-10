using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._2
{
    public partial class Form1 : Form
    {
        int[] numberArray;
        Random rnd;
        int odd;
        int number;
        public Form1()
        {
            InitializeComponent();
            numberArray = new int[20];
            rnd = new Random();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                number = rnd.Next(0, 101);
                numberArray[i] = number;
                lbxNumbers.Items.Add(number);
                if(number % 2 == 1)
                {
                    odd++;
                }
            }
            lbxNumbers.Items.Add("Lowest number: " + numberArray.Min());
            lbxNumbers.Items.Add("Highest number: " + numberArray.Max());
            lbxNumbers.Items.Add("Total numbers :" + numberArray.Count());
            lbxNumbers.Items.Add("Average of numbers: " + numberArray.Average());
            lbxNumbers.Items.Add("Number of odd items: " + odd);
        }
    }
}
