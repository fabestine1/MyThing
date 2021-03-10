using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbNames.SelectedItem.ToString());
            lbxNames.Items.Add(cbNames.SelectedItem);
            cbNames.Items.Remove(cbNames.SelectedItem);
            if(cbNames.Items.Count == 0)
            {
                MessageBox.Show("There is no item in!");
                Application.Exit();
            }

        }
    }
}
