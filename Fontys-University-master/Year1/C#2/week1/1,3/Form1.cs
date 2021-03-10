using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_3
{
    public partial class Dividing : Form
    {
        public Dividing()
        {
            InitializeComponent();
        }

        private void Dividing_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            int firstValue, secondValue, division, reminder;

            firstValue = int.Parse(this.firstValue.Text);
            secondValue = int.Parse(this.secondValue.Text);

            if (secondValue == 0)
            {
                this.division.Text = "Can NOT divide to 0";
                this.reminder.Text = "Can NOT divide to 0";
            }
            else
            {
                division = firstValue / secondValue;
                reminder = firstValue % secondValue;


                this.division.Text = division.ToString();
                this.reminder.Text = reminder.ToString();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
