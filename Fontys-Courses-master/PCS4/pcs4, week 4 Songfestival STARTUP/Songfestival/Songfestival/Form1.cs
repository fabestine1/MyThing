using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Songfestival
{
    public partial class Form1 : Form
    {
        private Songfestival mySongfestival;

        public Form1()
        {
            InitializeComponent();
            mySongfestival = new Songfestival();
            mySongfestival.AddContestant("the Netherlands"); 
            mySongfestival.AddContestant("Bulgaria"); 
            mySongfestival.AddContestant("Poland"); 
            mySongfestival.AddContestant("Belgium"); 
            mySongfestival.AddContestant("Romania"); 
            mySongfestival.AddContestant("Russia"); 
            mySongfestival.AddContestant("Ukraine");

            mySongfestival.AddScore("the Netherlands", 10); mySongfestival.AddScore("the Netherlands", 12); mySongfestival.AddScore("the Netherlands", 7); mySongfestival.AddScore("the Netherlands", 45);
            mySongfestival.AddScore("Bulgaria", 12); mySongfestival.AddScore("Bulgaria", 12); mySongfestival.AddScore("Bulgaria", 8); mySongfestival.AddScore("Bulgaria", 245);
            mySongfestival.AddScore("Poland", 1); mySongfestival.AddScore("Poland", 100);
            mySongfestival.AddScore("Belgium", 10); mySongfestival.AddScore("Belgium", 4); mySongfestival.AddScore("Belgium", 55);
            mySongfestival.AddScore("Romania", 10);
            mySongfestival.AddScore("Russia", 10); mySongfestival.AddScore("Russia", 12); mySongfestival.AddScore("Russia", 8); mySongfestival.AddScore("Russia", 7); mySongfestival.AddScore("Russia", 145);
            mySongfestival.AddScore("Ukraine", 12); mySongfestival.AddScore("Ukraine", 3); mySongfestival.AddScore("Ukraine", 270);
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            String country = tbCountry.Text;
            int score = Convert.ToInt32(tbScore.Text);
            mySongfestival.AddScore(country, score);
        }


        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            int score;
            double averageScore;
            lbInfo.Items.Clear();
            mySongfestival.CalculateInfo(tbCountry.Text, out score, out averageScore);
            lbInfo.Items.Add("The total score of " + tbCountry.Text + " is " + score + ".");
            lbInfo.Items.Add("The average score of all contestants is " + averageScore);
        }
    }
}
