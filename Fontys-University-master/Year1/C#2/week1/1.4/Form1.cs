using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4
{
    public partial class Form1 : Form
    {
        decimal euro, dollar, exchange;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void dollarToEuro_Click(object sender, EventArgs e)
        {
            dollar = decimal.Parse(this.dollarValue.Text);

            exchange = this.exchangeRate.Value;

            euro = dollar / exchange;

            this.euroValue.Text = euro.ToString("0.00");
        }

        private void euroToDollar_Click(object sender, EventArgs e)
        {
            euro = decimal.Parse(this.euroValue.Text);

            exchange = this.exchangeRate.Value;

            dollar = euro * exchange;

            this.dollarValue.Text = dollar.ToString("0.00");
        }


        private void madeBy_Click(object sender, EventArgs e)
        {
            this.didoProto.Visible = true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.didoProto.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
