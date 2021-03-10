using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3._1
{
    public partial class Form1 : Form
    {
        private List<ISomeone> myFamily;
        public Form1()
        {
            InitializeComponent();
            myFamily = new List<ISomeone>();
            myFamily.Add(new GrownUp("Mother"));
            myFamily.Add(new Baby("Emma"));
            myFamily.Add(new GrownUp("Father"));
            myFamily.Add(new Dog(21));
            myFamily.Add(new Flower(Color.Red));
            foreach (ISomeone someone in myFamily)
            {
                lbxFamily.Items.Add(someone.IntroduceYourself());
            }
        }

        private void btnGoodMorning_Click(object sender, EventArgs e)
        {
            lblGoodMorning.Text = myFamily[lbxFamily.SelectedIndex].SayGoodMorning(Convert.ToInt32(numericUpDownDay.Value));
        }

        private void btnGoodNight_Click(object sender, EventArgs e)
        {
            lblGoodNight.Text = myFamily[lbxFamily.SelectedIndex].SayGoodNight(Convert.ToInt32(numericUpDownHours.Value));
        }
    }
}
