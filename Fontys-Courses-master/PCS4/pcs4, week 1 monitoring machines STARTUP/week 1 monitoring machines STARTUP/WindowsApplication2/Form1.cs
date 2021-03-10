using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private ManufacturingCompany mc;
        private String fileName;
        public Form1()
        {
            InitializeComponent();
            mc = new ManufacturingCompany("VDL assembling Mini Cooper");
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
                    m.CriticalState += new Machine.CriticalStateHandler(Warn);
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

        private void Warn(Machine m, String r)
        {
            lbWarnings.Items.Add(m.Name + " - " + r);
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
            Machine m = mc.GetMachine(tbMachineName.Text);
            if (m != null)
            {
                if(btnLogging.Text == "Start logging")
                {
                    using (OpenFileDialog ofd = new OpenFileDialog())
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            fileName = ofd.FileName;
                            m.CriticalState += new Machine.CriticalStateHandler(LogWarnings);
                            btnLogging.Text = "Stop logging";
                        }
                    }
                }
                else
                {
                    m.CriticalState -= new Machine.CriticalStateHandler(LogWarnings);
                    btnLogging.Text = "Start logging";
                }
            }
            else
            {
                MessageBox.Show("We do not have a machine with this name");
            }
        }

        private void LogWarnings(Machine m, String r)
        {
            StreamWriter sw = null;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(DateTime.Now + " " + m.Name + " - " + r);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //todo
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = null;
                    try
                    {
                        fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        BinaryFormatter bf = new BinaryFormatter();

                        foreach(Machine m in mc.Machines)
                        {
                            m.removeAllCriticalStateHandlers();
                        }
                        bf.Serialize(fs, mc);
                    }
                    catch(IOException ex)
                    {
                        MessageBox.Show("Error writing to file: " + ex.Message);
                    }
                    catch(SerializationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (fs != null) fs.Close();
                    }
                }
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //todo
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = null;
                    try
                    {
                        fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        BinaryFormatter bf = new BinaryFormatter();

                        mc = (ManufacturingCompany)bf.Deserialize(fs);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (fs != null) fs.Close();
                    }
                }
            }
        }

    }
}