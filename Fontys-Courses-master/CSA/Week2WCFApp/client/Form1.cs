using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        private ServiceRef.CalculatorClient proxy;
        public Form1()
        {
            InitializeComponent();
            // instantiate a proxy to contact the service
            proxy = new ServiceRef.CalculatorClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.Add(number1, number2);
            tbResult.Text = answer.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.Substract(number1, number2);
            tbResult.Text = answer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.Multiply(number1, number2);
            tbResult.Text = answer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.Divide(number1, number2);
            tbResult.Text = answer.ToString();
        }
    }
}
