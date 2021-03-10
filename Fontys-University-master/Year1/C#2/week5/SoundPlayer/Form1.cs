using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundPlayer
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {  //the user pushed the OK-button of openFileDialog1
                tbFilename.Text = openFileDialog1.FileName;
            }
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }
    }
}
