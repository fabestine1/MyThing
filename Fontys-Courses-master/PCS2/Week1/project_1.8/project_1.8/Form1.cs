using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckEmpty()
        {
            if (tbxOrderNumber.Text != "" && tbxOrderNumber.Text != "Order number" && tbxCustomerName.Text != "" && tbxCustomerName.Text != "Customer name" && tbxShippingAddress.Text != "" && tbxShippingAddress.Text != "Shipping address")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void cbxWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWhite.CheckState.ToString() == "Checked")
            {
                if (CheckEmpty() == true)
                {
                    tbxWhiteQuantity.Enabled = true;
                }

            }
            else
            {
                tbxWhiteQuantity.Enabled = false;
                tbxWhiteQuantity.Text = "0";
            }
        }

        private void cbxBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBlack.CheckState.ToString() == "Checked")
            {
                if (CheckEmpty() == true)
                {
                    tbxBlackQuantity.Enabled = true;
                }
            }
            else
            {
                tbxBlackQuantity.Enabled = false;
                tbxBlackQuantity.Text = "0";
            }
        }

        private void cbxBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBlue.CheckState.ToString() == "Checked")
            {
                if (CheckEmpty() == true)
                {
                    tbxBlueQuantity.Enabled = true;
                }
            }
            else
            {
                tbxBlueQuantity.Enabled = false;
                tbxBlueQuantity.Text = "0";
            }
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            if (tbxWhiteQuantity.Text == "")
            {
                tbxWhiteQuantity.Text = Convert.ToString(0);
            }
            if (tbxBlackQuantity.Text == "")
            {
                tbxBlackQuantity.Text = Convert.ToString(0);
            }
            if (tbxBlueQuantity.Text == "")
            {
                tbxBlueQuantity.Text = Convert.ToString(0);
            }
            int amount = Convert.ToInt32(tbxWhiteQuantity.Text) + Convert.ToInt32(tbxBlackQuantity.Text) + Convert.ToInt32(tbxBlueQuantity.Text);
            tbxTotalCost.Text = Convert.ToString(0.70 * amount);
            tbxTaxRate.Text = Convert.ToString(0.05 * Convert.ToDouble(tbxTotalCost.Text));
            tbxTotalCost.Text = Convert.ToString(Convert.ToDouble(tbxTotalCost.Text) + Convert.ToDouble(tbxTaxRate.Text));
            if (amount <= 20 && tbxTotalCost.Text != "0")
            {
                tbxTotalCost.Text = Convert.ToString(Convert.ToDouble(tbxTotalCost.Text) + 1.50);
                tbxShipCharg.Text = "1.50";
            }
            else
            {
                tbxShipCharg.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxOrderNumber.Text = "";
            tbxCustomerName.Text = "";
            tbxShippingAddress.Text = "";
            tbxWhiteQuantity.Text = "0";
            tbxBlackQuantity.Text = "0";
            tbxBlueQuantity.Text = "0";
        }
    }
}
