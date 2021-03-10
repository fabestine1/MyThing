using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace Event
{
    public partial class Form1 : Form
    {
        RFID reader;
        public Form1()
        {
            InitializeComponent();

            reader = new RFID();
            reader.Tag += Reader_Tag;
            reader.Open(5000);
        }
        private void Reader_Tag(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag == "28007bcb0f")
            {
                //lblStatus.Text = "Approved";
                //lblStatus.ForeColor = Color.Green;
                //button1.Enabled = false;
               //// button2.Enabled = false;
               // button3.Enabled = false;
                ///button4.Enabled = false;

            }
            //MessageBox.Show("dsd");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant frm = new Restaurant(this);
            frm.Show();
            frm.Show();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Materials frm = new Materials(this);
            frm.Show();
        }
    }
}
