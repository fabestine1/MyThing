using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_8
{
    public partial class Form1 : Form
    {
        decimal price;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 2.5M;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 3M;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 3.25M;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal total, tax, shipping = 1.50M;
            int quantity;

            quantity = int.Parse(this.quantity.Text);

            total = price * quantity;

            tax = total * 0.05M;

            total += tax;

            if(quantity > 20)
            {
                shipping = 0M;
            }

            this.total.Text = total.ToString("0.00") + "$";
            this.tax.Text = tax.ToString("0.00") + "$";
            this.shipping.Text = shipping.ToString("0.00") + "$";
        }


        private void quantity_Click(object sender, EventArgs e)
        {
            if (this.custName.Text != "" && this.orderNum.Text != "" && this.address.Text != "")
            {
                if (this.redDice.Checked == true || this.greenDice.Checked == true || this.yellowDice.Checked == true)
                {
                    quantity.ReadOnly = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.custName.Text = "";
            this.orderNum.Text = "";
            this.address.Text = "";
            this.quantity.Text = "";
            this.total.Text = "";
            this.tax.Text = "";
            this.shipping.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
