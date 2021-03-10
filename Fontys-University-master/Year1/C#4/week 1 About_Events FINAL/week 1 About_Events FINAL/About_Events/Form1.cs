using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace About_Events
{
    public partial class Form1 : Form
    {
        private Motorbike ValentinosBike, MarcsBike;

        public Form1()
        {
            InitializeComponent();
            ValentinosBike = new Motorbike("Valentino Rossi", 200);
            MarcsBike = new Motorbike("Marc Marquez", 180);

            this.groupBox1.Text = ValentinosBike.NameOfDriver;
            this.groupBox2.Text = MarcsBike.NameOfDriver;

            UpdateValentinosDisplay(ValentinosBike, ValentinosBike.Speed);
            UpdateMarcsDisplay(MarcsBike, MarcsBike.Speed);

            ValentinosBike.speedChanged += new Motorbike.SpeedChangedHandler(this.UpdateValentinosDisplay);
            ValentinosBike.speedingTooFast += new Motorbike.SpeedChangedHandler(this.ShowInListbox);
        }


        private void UpdateValentinosDisplay(Motorbike m, int currentSpeed)
        {
            this.label1.Text = m.Speed.ToString();
            //or this.label1.Text = currentSpeed.ToString();
        }

        private void UpdateMarcsDisplay(Motorbike m, int currentSpeed)
        {
            this.label2.Text = m.Speed.ToString();
        }

        private void ShowInListbox(Motorbike m, int s)
        {
            this.listBox1.Items.Add(m.NameOfDriver + " drives to fast by: " + s.ToString() + " km/h.");
        }

        private void btnAdjust1_Click(object sender, EventArgs e)
        {
            ValentinosBike.Accelerate(Convert.ToInt32(textBox1.Text));
        }

        private void btnAdjust2_Click(object sender, EventArgs e)
        {
            MarcsBike.Accelerate(Convert.ToInt32(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValentinosBike.speedingTooFast += new Motorbike.SpeedChangedHandler(this.Extra);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValentinosBike.speedingTooFast -= new Motorbike.SpeedChangedHandler(this.Extra);
        }

        private void Extra(Motorbike m, int currentSpeed)
        {
            MessageBox.Show(m.NameOfDriver + " goes too fast");
        }
    }
}
