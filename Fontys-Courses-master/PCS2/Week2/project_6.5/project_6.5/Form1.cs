using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_6._5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int count7;
        int[] throws = new int[11];
        public Form1()
        {
            InitializeComponent();
            int random;
            for (int i = 0; i < 36000; i++)
            {
                foreach (int diceThrow in throws)
                {
                    if(diceThrow == 7)
                    {
                        count7++;
                    }
                }
                if(count7 > 1/6 * throws.Length)
                {
                    random = rnd.Next(1, 7) + rnd.Next(1, 7);
                }
                else
                {
                    random = rnd.Next(4, 6) + rnd.Next(2, 3);
                }
                throws[random - 2]++;
            }
            dataGridView1.Rows.Add(throws[0].ToString(), throws[1].ToString(), throws[2].ToString(), throws[3].ToString(), throws[4].ToString(), throws[5].ToString(), throws[6].ToString(), throws[7].ToString(), throws[8].ToString(), throws[9].ToString(), throws[10].ToString());
        }
    }
}
