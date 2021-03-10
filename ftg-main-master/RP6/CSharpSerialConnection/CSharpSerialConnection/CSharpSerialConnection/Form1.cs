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
            rtbLog.Invoke(
                new EventHandler(
                    delegate 
                    {
                        string s = sPort.ReadExisting();
                        Console.WriteLine(s);
                        rtbLog.AppendText(s);

                        string[] split = s.Split(new Char[] {'{', ';', '}'});
                        
                        switch (split[0])
                        {
                            case "cmd=0x05":
                                {
                                    lblTopSpeed.Text = "Top Speed Achieved: " + FromHex(split[1]).ToString();
                                    break;
                                }
                            case "cmd=0x06":
                                {
                                    lblFuelLvl.Text = "Battery Level: " + FromHex(split[1]).ToString();
                                    break;
                                }
                        }
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
                    sPort = new SerialPort("COM13", 38400, Parity.None, 8, StopBits.One);
                    sPort.DataReceived += new SerialDataReceivedEventHandler(RenesSerialDataReceived);
                    sPort.Open();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Creation failed");
                }
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

        private void tbSendRaw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sPort != null)
                {
                    sPort.Write(tbSendRaw.Text);
                    tbSendRaw.Text = "";
                }
            }
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write(tbSendRaw.Text);
                tbSendRaw.Text = "";
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x01}");
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x03}");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x04}");
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0x02}");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                try
                {
                    sPort.Close();
                    sPort = null;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Failed to close port");
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{cmd=0xFF}");
            }
        }

        public static int FromHex(string value)
        {
            // strip the leading 0x
            if (value.StartsWith("val=0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(6);
            }
            return Int32.Parse(value, System.Globalization.NumberStyles.HexNumber);
        }

        
    }
}