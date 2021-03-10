using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxEuro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnToDollar_Click(object sender, EventArgs e)
        {

            tbxDollar.Text = Convert.ToString(Convert.ToDouble(tbxEuro.Text) * Convert.ToDouble(exchangeRate.Value));
        }

        private void btnToEuro_Click(object sender, EventArgs e)
        {
            tbxEuro.Text = Convert.ToString(Convert.ToDouble(tbxDollar.Text) / Convert.ToDouble(exchangeRate.Value));
        }

        private void madeBy_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exchangeRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblExchangeRate_Click(object sender, EventArgs e)
        {

        }

        private void rbtnDollar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDollar.Checked)
            {
                lblExchangeRate.Text = "Exchannge rate 1 euro = $";
                lblDollar.Text = "$";
            }
        }

        private void rbtnYuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYuan.Checked)
            {
                lblExchangeRate.Text = "Exchannge rate 1 euro = ¥";
                lblDollar.Text = "¥";
            }
        }

        private void rbtnRupee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRupee.Checked)
            {
                lblExchangeRate.Text = "Exchannge rate 1 euro = ₹";
                lblDollar.Text = "₹";
            }
        }

        private void rbtnLev_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLev.Checked)
            {
                lblExchangeRate.Text = "Exchannge rate 1 euro = BGN";
                lblDollar.Text = "BGN";
            }
        }
    }
}
