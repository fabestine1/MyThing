using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cbNames.Text);

            this.cbNames.Items.Remove(this.cbNames.Text);
        }
    }
}
