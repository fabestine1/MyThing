using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._4_and_4._5
{
    public partial class Form1 : Form
    {

        SneezCalculator sneez;
        public Form1()
        {
            InitializeComponent();
            sneez = new SneezCalculator();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Catalan number is: " + sneez.GetSeezNumber(Convert.ToInt32(textBox1.Text));
                label1.Show();

            }
            catch (Exception) { MessageBox.Show("error"); }
        }
    }
}
