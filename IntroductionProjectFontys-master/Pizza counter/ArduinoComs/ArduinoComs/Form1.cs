using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoComs
{
    public partial class Form1 : Form
    {
        public SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            myport = new SerialPort
            {
                BaudRate = 9600,
                PortName = "COM3"
            };
            myport.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string Get_Counter_Value()
        {
            string receivedValue = myport.ReadExisting();
            string[] tokens = receivedValue.Split('-');
            return tokens[tokens.Length - 1];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            output.Text = Get_Counter_Value();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            myport.Write("1");
            output.Text = Get_Counter_Value();
        }
    }
}
 