using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateProduct(int a, int b, out int product)
        {
            product = a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            CalculateProduct(5, 7, out result);
            MessageBox.Show(result.ToString());
        }
        private void SwapVariables(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 6;
            int b = 7;
            SwapVariables(ref a, ref b);
            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());
        }
    }
}
