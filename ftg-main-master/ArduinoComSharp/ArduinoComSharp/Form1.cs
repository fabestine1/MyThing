using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Garagemanagement
{
    public partial class Form1 : Form
    {
        private Arduino mega;
        public Form1()
        {
            InitializeComponent();
            mega = new Arduino("", 19200);

            DataInterpretor dataman = new DataInterpretor();

            dataman.addString("{1,\"hallo, kaas\",5}");

            ComData comdata = dataman.getComData();

            int param1=0;
            string param2 = "";
            int param3 = 0;

            comdata.Get(0,ref param1);
            comdata.Get(1, ref param2);
            comdata.Get(1, ref param3);

            Debug.Write(param1 + "," + param2 + "," + param3);

            /*StringEater eater = new StringEater();

            eater.String("hallo there dude");
            eater.eatUntil(test);

            Debug.Write(eater.buffer);*/
            tmrConnectionCheck.Enabled = true;
        }

        void iets()
        {
            
        }
        /*int test(int k, char c, string s)
        {
            return 1;
        }*/

        private void btSend_Click(object sender, EventArgs e)
        {
            mega.Send((int)numericUpDown1.Value,tbInput.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mega.IsOpen)
            {
                lblConnState.Text = "Connected (" + mega.ComPort + ", "+mega.BaudRate+")";
                lblConnState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
                {
                    lblConnState.Text = "DisConnected (?)";
                    lblConnState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
        }
    }
}
