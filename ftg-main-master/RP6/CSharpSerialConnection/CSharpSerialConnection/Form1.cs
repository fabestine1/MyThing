using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpSerialConnection
{
    public partial class Form1 : Form
    {
        private SerialPort sPort;

        public Form1()
        {
            InitializeComponent();
            sPort = null;
        }

        private void RenesSerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Commandline.Invoke(
                new EventHandler(
                    delegate 
                    {
                        string s = sPort.ReadExisting();

                        Feedback.AppendText(s);

                        Feedback.SelectionStart = Feedback.Text.Length;
                        Feedback.ScrollToCaret();
                    }
                 )
            );
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (sPort == null)
            {
                try
                {
                    sPort = new SerialPort("COM28", 38400, Parity.None, 8, StopBits.One);
                    sPort.DataReceived += new SerialDataReceivedEventHandler(RenesSerialDataReceived);
                    sPort.Open();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Creation failed");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x02}");
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x02;val=0x" + trackBar1.Value.ToString("X") + "}");
            }
        }

        private void btnGetSpeed_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x05}");
            }
        }

        private void btnGetFuelLevels_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x06}");
            }
        }

        private void tmrLifetime_Tick(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0xEF}");
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x01;val=0x"+trackBar1.Value.ToString("X")+"}");
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x03}");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0xFF}");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x04}");
            }
        }
    }
}