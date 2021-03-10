using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private ManufacturingCompany mc;
        public Form1()
        {
            InitializeComponent();
            mc = new ManufacturingCompany("VDL assembling Mini Cooper");
            Machine machine = new Machine("machine", 12, 12);
            mc.AddMachine(machine);
            machine.CriticalState += new Machine.CriticalStateHandler(ShowInListBox);

        }

        private void ShowInListBox(Machine sender, String reason)
        {
            this.lbWarnings.Items.Add(sender.Name + " " + reason);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add(mc.ToString());
            lbInfo.Items.Add("");
            foreach (Machine m in mc.Machines)
            {
                lbInfo.Items.Add(m.ToString());
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = new Machine(tbMachineName.Text, Convert.ToInt32(tbTemp.Text), Convert.ToInt32(tbPressure.Text));
               
                if (mc.AddMachine(m))
                {
                    MessageBox.Show("Successfully added");
                }
                else
                {
                    MessageBox.Show("We already have a machine with that name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in some numbers for temperature and pressure");
            }

        }

        private void btnSimulateTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetTemperature(Convert.ToInt32(tbTemp.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for temperature");
            }
        }

        private void btnSimulatePressure_Click(object sender, EventArgs e)
        {
            //todo
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetPressure(Convert.ToInt32(tbPressure.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for pressure");
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //todo
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //todo
        }

    }
}