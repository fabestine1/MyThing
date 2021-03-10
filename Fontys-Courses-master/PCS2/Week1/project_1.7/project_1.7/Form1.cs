using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPointsEarned_Click(object sender, EventArgs e)
        {

        }

        private void lblPurchased_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbxPurchased.Text) >= 0)
            {
                if (tbxPurchased.Text == "0")
                {
                    tbxPointsEarned.Text = "0";
                }
                else if (tbxPurchased.Text == "1")
                {
                    tbxPointsEarned.Text = "5";
                }
                else if (tbxPurchased.Text == "2")
                {
                    tbxPointsEarned.Text = "15";
                }
                else if (tbxPurchased.Text == "3")
                {
                    tbxPointsEarned.Text = "30";
                }
                else
                {
                    tbxPointsEarned.Text = "60";
                }
            }
        }
    }
}
