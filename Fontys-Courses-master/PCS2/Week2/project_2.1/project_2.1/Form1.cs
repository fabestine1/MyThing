using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
                if (tbOperator.Text == "+") {
                    lbResult.Text = Convert.ToString(Convert.ToInt32(tbOperand1.Text) + Convert.ToInt32(tbOperand2.Text));
                }
                else if (tbOperator.Text == "-")
                {
                        lbResult.Text = Convert.ToString(Convert.ToInt32(tbOperand1.Text) - Convert.ToInt32(tbOperand2.Text));
                }
                else if (tbOperator.Text == "*")
                {
                    lbResult.Text = Convert.ToString(Convert.ToInt32(tbOperand1.Text) * Convert.ToInt32(tbOperand2.Text));
                }
                else if (tbOperand2.Text == "0" && tbOperator.Text == "/")
                {
                    lbResult.Text = "Division by 0 is not permitted";
                }
                else if (tbOperator.Text == "/")
                {
                    lbResult.Text = Convert.ToString(Convert.ToInt32(tbOperand1.Text) / Convert.ToInt32(tbOperand2.Text));
                }
        }

        private void tbOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsDigit((char)(e.KeyChar)))
            {
                e.KeyChar = (char)0;
            }
        }

        private void tbOperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsDigit((char)(e.KeyChar)))
            {
                e.KeyChar = (char)0;
            }
        }

        private void tbOperator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && e.KeyChar != (char)43 && e.KeyChar != (char)45 && e.KeyChar != (char)42 && e.KeyChar != (char)47)
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
