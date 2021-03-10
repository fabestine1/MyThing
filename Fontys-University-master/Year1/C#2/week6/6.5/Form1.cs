using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._5
{
    public partial class Form1 : Form
    {
        TableLayoutPanel table;
        
        Random rnd;

        public Form1()
        {
            InitializeComponent();

            rnd = new Random();

            table = new TableLayoutPanel();

            this.Controls.Add(table);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int first, second, sum;

            int[] counter = new int[11];

            int[,] table = new int[6,6];

            for (int i = 0; i < 36000; i++)
            {
                first = rnd.Next(1, 7);
                second = rnd.Next(1, 7);

                sum = first + second;

                switch(sum)
                {
                    case 2:
                        counter[0]++;
                        break;
                    case 3:
                        counter[1]++;
                        break;
                    case 4:
                        counter[2]++;
                        break;
                    case 5:
                        counter[3]++;
                        break;
                    case 6:
                        counter[4]++;
                        break;
                    case 7:
                        counter[5]++;
                        break;
                    case 8:
                        counter[6]++;
                        break;
                    case 9:
                        counter[7]++;
                        break;
                    case 10:
                        counter[8]++;
                        break;
                    case 11:
                        counter[9]++;
                        break;
                    case 12:
                        counter[10]++;
                        break;
                }

                for (int z = 0; z < 6; z++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (first - 1 == z && second -1 == j)
                        {
                            table[z, j]++;
                        }
                    }
                }
            }

            for(int i = 0; i < 11; i++)
            {
                this.lsbCounter.Items.Add(i + 2 + " - " + counter[i]);
            }    

            for (int i = 0; i < 6; i++)
            {
                this.dgvTable.Rows.Add(table[i, 0], table[i, 1], table[i, 2], table[i, 3],
                    table[i, 4], table[i, 5]);
            }
        }
    }
}
