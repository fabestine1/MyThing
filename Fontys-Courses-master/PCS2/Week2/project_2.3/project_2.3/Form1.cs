using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sufficient = 0;
        private int insufficient = 0;
        private int total = 0;
        private double sum = 0;
        private double average = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxMarks.Items.Clear();
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbxMark.Text) >= 0 && Convert.ToDouble(tbxMark.Text) <= 10)
            {
                lbxMarks.Items.Add(Convert.ToDouble(tbxMark.Text));
                if (Convert.ToDouble(tbxMark.Text) >= 5.5)
                {
                    sufficient++;
                }
                else
                {
                    insufficient++;
                }
                sum += Convert.ToDouble(tbxMark.Text);
            }
            else
            {
                MessageBox.Show("Incorrect mark");
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            tbxSufficient.Text = Convert.ToString(sufficient);
            tbxInsufficient.Text = Convert.ToString(insufficient);
            total = sufficient + insufficient;
            tbxTotal.Text = Convert.ToString(total);
            average = sum / total;
            tbxAverage.Text = Convert.ToString(average);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
