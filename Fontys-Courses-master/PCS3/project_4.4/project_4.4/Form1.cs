using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._4
{
    public partial class Form1 : Form
    {
        private SneezCalculator sneezCalculator;
        public Form1()
        {
            InitializeComponent();
            sneezCalculator = new SneezCalculator();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text = sneezCalculator.GetSneezeNumber(Convert.ToInt32(tbxIndex.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Index input is in incorrect format!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Index input cannot be divided by zero!");
            }
            catch (NoSuchSneezNumberExcepiton ne)
            {
                MessageBox.Show(ne.Message);
            }
        }
    }
}
