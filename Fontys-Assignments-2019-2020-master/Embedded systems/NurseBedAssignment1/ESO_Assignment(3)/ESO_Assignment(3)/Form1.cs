using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESO_Assignment_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String time = DateTime.Now.ToString("HHmm");
            serialPort1.WriteLine(time);

            String formatedTime = DateTime.Now.ToString("HH:mm"); ;
            double number;

            if (serialPort1.BytesToRead > 0)
            {
                string line = serialPort1.ReadLine();
                line = line.TrimEnd();
                if (line == "alarmon")
                {
                    pictureBox1.BackColor = Color.Red;
                    lbxAlarmHistory.Items.Add(formatedTime + " Alarm on");
                }
                if (line == "tempabove")
                {
                    pictureBox1.BackColor = Color.Red;
                    lbxAlarmHistory.Items.Add(formatedTime + " Temperature above 27°C");
                }
                if (line == "tempbelow")
                {
                    pictureBox1.BackColor = Color.Red;
                    lbxAlarmHistory.Items.Add(formatedTime + " Temperature below 16°C");
                }
                if (Double.TryParse(line, out number))
                {
                    number = double.Parse(line);
                    lblRoomTemp.Text = $"Room temperature: {number}°C";

                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            timer1.Start();
            pictureBox1.BackColor = Color.Green;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("alarmoff");
            String time = DateTime.Now.ToString("HH:mm");
            lbxAlarmHistory.Items.Add(time + " Alarm reset");
            pictureBox1.BackColor = Color.Green;
        }
    }
}
