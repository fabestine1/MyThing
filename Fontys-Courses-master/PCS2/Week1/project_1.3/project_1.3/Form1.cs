using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbAdivB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAmodB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbIntDiv_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            tbAdivB.Text = Convert.ToString(Convert.ToInt32(tbA.Text) / Convert.ToInt32(tbB.Text));
            tbAmodB.Text = Convert.ToString(Convert.ToInt32(tbA.Text) % Convert.ToInt32(tbB.Text));
        }

        private void lbA_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
