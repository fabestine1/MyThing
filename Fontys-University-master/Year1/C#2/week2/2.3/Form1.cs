using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._3
{
    public partial class Form1 : Form
    {
        int sufficient = 0, insufficient = 0, total = 0;
        double average = 0, mark, markSum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            mark = int.Parse(this.tbAdd.Text);  

            if (mark < 0)
            {
                MessageBox.Show("Marks can NOT be less than 0");
            }
            else if (mark > 10)
            {
                MessageBox.Show("Marks can NOT be more than 10");
            }
            else
            {
                this.gradeList.Items.Add(this.tbAdd.Text);

                if (mark >= 5.5)
                {
                    sufficient++;
                }
                else
                {
                    insufficient++;
                }

                total++;

                markSum += mark;

                average += mark / total;

                this.tbSufficient.Text = sufficient.ToString();
                this.tbInsufficient.Text = insufficient.ToString();
                this.tbTotal.Text = total.ToString();
                this.tbAverage.Text = average.ToString("#.##");
                this.tbAdd.Text = String.Empty;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.gradeList.Items.Clear();
            this.tbSufficient.Text = String.Empty;
            this.tbInsufficient.Text = String.Empty;
            this.tbTotal.Text = String.Empty;
            this.tbAverage.Text = String.Empty;
        }
    }
}
