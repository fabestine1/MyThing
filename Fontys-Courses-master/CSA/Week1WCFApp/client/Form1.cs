using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using CalculatorContract;

namespace client
{
    public partial class Form1 : Form
    {
        CalculatorClientProxy proxy;
        public Form1()
        {
            InitializeComponent();
            // instantiate a proxy to contact the service
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            EndpointAddress endpointAddress = new EndpointAddress(address);
            proxy = new CalculatorClientProxy(binding, endpointAddress);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.GetCalculatorService().Add(number1, number2);
            tbResult.Text = answer.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.GetCalculatorService().Substract(number1, number2);
            tbResult.Text = answer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.GetCalculatorService().Multiply(number1, number2);
            tbResult.Text = answer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbA.Text);
            double number2 = Convert.ToDouble(tbB.Text);
            double answer = proxy.GetCalculatorService().Divide(number1, number2);
            tbResult.Text = answer.ToString();
        }
    }
}
