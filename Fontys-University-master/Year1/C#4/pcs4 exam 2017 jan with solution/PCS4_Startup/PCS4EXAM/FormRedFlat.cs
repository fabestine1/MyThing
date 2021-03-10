using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS4EXAM
{
    public partial class FormRedFlat : Form
    {
        private int countDownCounter;
        public FormRedFlat()
        {
            InitializeComponent();
            this.Visible = true;
        }

        /// <summary>
        /// shows information about startup su blinking on the screen
        /// </summary>
        /// <param name="su"></param>
        public void AlertMe(StartUp su)
        {
            this.label2.Text = su.Name + " has reached its threshold";
            this.label2.Visible = true;
            this.countDownCounter = 15;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Visible = !this.label2.Visible;
            this.countDownCounter--;
            if (this.countDownCounter == 0) this.timer1.Enabled = false;
        }
    }
}
