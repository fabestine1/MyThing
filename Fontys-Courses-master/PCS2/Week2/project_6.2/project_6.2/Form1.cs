using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_6._2
{
    public partial class Form1 : Form
    {
        public enum Coins { HEADS, TAILS }
        private int counterHeads;
        private int counterTails;
        public Form1()
        {
            InitializeComponent();
        }

        public Coins Flip()
        {
            Random rnd = new Random();
            int side = rnd.Next(0,2);
            return (Coins)rnd.Next(2);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Flip();
            lblResult.Text = "Heads: " + counterHeads + "\nTails: " + counterTails;
        }
    }
}
