using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are suicidal");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.progress.Value = this.track.Value;
            this.lProgress.Text = this.track.Value.ToString();
        }

        private void CrimsonBack_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Crimson;
        }

        private void CyanBack_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void IndigoBack_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Indigo;
        }
    }
}
