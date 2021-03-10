using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garagemanagement
{
    public partial class ControlPanelView : Form
    {

        private List<string> devicenames;

        public string selecteddevicename {get; private set;}

        public ControlPanelView()
        {
            InitializeComponent();

            selecteddevicename = null;

            devicenames = new List<string>();

            sendTSelf.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int target;
            object report;

            while (Reporter.GetReport(out target, out report))
            {
                switch (target)
                {
                    case 1: //connected divices case 2: disconnect device case 3: log
                        {
                            lbDevices.Items.Add(report.ToString());
                            break;
                        }
                    case 2: //disconnect device
                        {
                            string devicename = report.ToString();

                            if (devicename.Length > 0)
                            {
                                foreach (string item in lbDevices.Items)
                                {
                                    if (item.Contains(devicename))
                                    {
                                        lbDevices.Items.Remove(item);
                                        if (selecteddevicename == devicename)
                                        {
                                            selecteddevicename = null;
                                            commandtxtbox.Enabled = true;
                                        }
                                        break;
                                    }
                                }

                                for (int i = 0; i < devicenames.Count; i++)
                                {
                                    if (devicenames.ElementAt(i) == devicename)
                                    {
                                        devicenames.RemoveAt(i);
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    case 3://remember devicename
                        {
                            string devicename = report as string;


                            for (int i = 0; i < devicenames.Count; i++)
                            {
                                if (devicenames.ElementAt(i) == devicename)
                                {
                                    devicenames.RemoveAt(i);
                                    break;
                                }
                            }

                            devicenames.Add(devicename);

                            break;
                        }
                    case 4: //log
                        {
                            lbLog.Items.Add(report.ToString());
                            break;
                        }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
        }

        private void lbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbDevices.SelectedItem is string)
            {
                string text = lbDevices.SelectedItem as string;

                int firstindex = text.IndexOf("'");
                int lastindex = text.IndexOf("'", firstindex+1);

                if (firstindex > -1 && lastindex > -1)
                {
                    firstindex++;

                    string devicename = text.Substring(firstindex, lastindex - firstindex);

                    if (devicename.Length > 0)
                    {
                        Communication device = GetDevice(devicename);

                        if (device != null)
                        {
                            selecteddevicename = devicename;
                            commandtxtbox.Enabled = true;
                            targetIDbox.Visible = true;

                            targetIDbox.Value = device.comID;
                            return;
                        }

                    }
                }
            }
            selecteddevicename = null;
            commandtxtbox.Enabled = false;
            targetIDbox.Visible = false;
        }

        private void DoSendSomething()
        {
            if (selecteddevicename != null && commandtxtbox.Text.Length > 0)
            {
                Communication device = GetDevice(selecteddevicename);

                if (device != null)
                {

                    if (sendTSelf.Checked)
                    {

                        device.IncomingCommand_Handle(
                                    "{" +
                                    targetIDbox.Value.ToString() +
                                    "," +
                                    device.comID.ToString() +
                                    "," +
                                    commandtxtbox.Text +
                                    "}");

                        commandtxtbox.Text = "";
                    }
                    else
                    {
                        if (device.Send(
                                    "{" +
                                    targetIDbox.Value.ToString() +
                                    "," +
                                    device.comID.ToString() +
                                    "," +
                                    commandtxtbox.Text +
                                    "}"))
                        {
                            commandtxtbox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Couldn't send command..\nSomething went wrong!");
                        }
                    }
                }
            }
        }

        private void commandtxtbox_Click(object sender, EventArgs e)
        {
            DoSendSomething();
        }

        private Communication GetDevice(string devicename)
        {
            if(devicename.Length > 0)
            {
                foreach (Communication device in Program.LocalDevices)
                {
                    if (device.DeviceName == devicename)
                    {
                        return device;
                    }
                }
            }
            return null;
        }

        private void commandtxtbox_CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DoSendSomething();
            }
        }

        private void sendTSelf_CheckedChanged(object sender, EventArgs e)
        {
            if(sendTSelf.Checked)
            {
                commandtxtbox.Enabled = true;
                sendTSelf.Text = "Send to local";
                textBox1.Text = "Send data to the local data handler. The number box represents the target's comid";
            }
            else
            {
                if(selecteddevicename != null)
                {
                    commandtxtbox.Enabled = true;
                }
                else
                {
                    commandtxtbox.Enabled = false;
                }
                if (Program.MasterServer.Connected)
                {
                    targetIDbox.Value = Program.MasterServer.serverID;
                }
                sendTSelf.Text = "Send to Master";
                textBox1.Text = "Send data through device's communication channels. The number box represents the target's comid";
            }
        }
    }
}
