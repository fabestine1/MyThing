using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        bool[] secondClass = new bool[5];
        bool[] firstClass = new bool[5];

        private void UpdateListBox()
        {
            this.lsbFirstClass.Items.Clear();
            this.lsbSecondClass.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (firstClass[i])
                {
                    this.lsbFirstClass.Items.Add(i + 6 + " - unavailable");
                }
                else
                {
                    this.lsbFirstClass.Items.Add(i + 6 + " - available");
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if(secondClass[i])
                {
                    this.lsbSecondClass.Items.Add(i + 1 + " - unavailable");
                }
                else
                {
                    this.lsbSecondClass.Items.Add(i + 1 + " - available");
                }
            }
        }

        private void AssignSeat(bool[] chosenClass)
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {

                if (chosenClass[i] == false)
                {
                    chosenClass[i] = true;

                    break;
                }
                else
                {
                    count++;
                    if (count == 5)
                    {
                        MessageBox.Show("No seats availiable for this class, try the other class");
                    }
                }
            }

            UpdateListBox();
        }

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                secondClass[i] = false;
                firstClass[i] = false;
            }

            UpdateListBox();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            bool check = true;
            int br = 0;
            for (int i = 0; i < 5; i++)
            {
                
                if (firstClass[i] && secondClass[i])
                {
                    br++;      
                }
                if (br == 5)
                {
                    MessageBox.Show("There are no available seats, next flight is after 3 hours");

                    check = false;
                }
            }

            if (check)
            {
                if (this.rbtnFristClass.Checked)
                {
                    AssignSeat(firstClass);
                }
                else if (this.rbtnSecondClass.Checked)
                {
                    AssignSeat(secondClass);
                }
            }
        }
    }
}
