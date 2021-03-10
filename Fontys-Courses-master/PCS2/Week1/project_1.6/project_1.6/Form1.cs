using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gallons_ValueChanged(object sender, EventArgs e)
        {
            tbxTown.Text = Convert.ToString(Convert.ToDouble(gallons.Value) * 21.5);
            tbxHighway.Text = Convert.ToString(Convert.ToDouble(gallons.Value) * 26.8);
        }

        private void tbxTown_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
