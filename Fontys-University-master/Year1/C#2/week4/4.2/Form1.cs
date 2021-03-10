using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnGo_Click(object sender, EventArgs e)
        {
            int lowest, highest, sum = 0, odd = 0;

            double avg;

            int[] numbers = new int[20];

            Random rnd = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 1000);

                this.lbNumbers.Items.Add(numbers[i]);
            }

            lowest = numbers[0];

            highest = numbers[0];

            for(int i = 0; i < numbers.Length; i++)
            {
                if(lowest > numbers[i])
                {
                    lowest = numbers[i];
                }
                if(highest < numbers[i])
                {
                    highest = numbers[i];
                }

                if (numbers[i] % 2 == 1)
                {
                    odd++;
                }

                sum += numbers[i]; 
            }

            avg = sum / 20;

            this.tbResults.Items.Add(lowest);
            this.tbResults.Items.Add(highest);
            this.tbResults.Items.Add(avg);
            this.tbResults.Items.Add(odd);
        }
    }
}
