using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace GUI_Pizza_L
{
    public partial class Form1 : Form
    {
        public SerialPort myport;
        private WebSocket ws = new WebSocket();

        private readonly string chefIp = "192.168.0.102";
        private readonly string chefPort = "85";
        private readonly string cashierIp  = "192.168.0.111";
        private readonly string cashierPort = "84";

        private readonly string marioEnding = "*M";
        private readonly string luigiEnding = "*L";


        public Form1()
        {
            InitializeComponent();
            myport = new SerialPort
            {
                BaudRate = 9600,
                PortName = "COM5"
            };
            myport.Open();

            Timer pizzaCounterTimer = new Timer
            {
                Interval = 1000
            };
            pizzaCounterTimer.Tick += new EventHandler(ChangeCounterValues);
            pizzaCounterTimer.Start();

            ws.connect(chefIp, chefPort, cashierIp, cashierPort);
        }

        private void ChangeCounterValues(object sender, EventArgs e)
        {
            if(myport.BytesToRead > 0)
            {
                string receivedValue = myport.ReadExisting();
                string[] tokens = receivedValue.Split('-');
                countLbl.Text = tokens[tokens.Length - 1];
            }
            GetOrders();
        }

        private void GetOrders()
        {
            // add pizzas to list box
            foreach (var item in ws.messages)
            {
                bool isRemote = item.Contains(marioEnding);
                if (isRemote)
                {
                    string pizzaName = item.Replace(marioEnding, "");
                    readyPizzas.Items.Add(pizzaName);
                }
            }

            ws.messages.Clear();
        }

        private void SendRemovedPizza(string selectedPizza)
        {
            ws.sendMsg(selectedPizza);
        }

        private void SendSignalToArduino(string data = "1")
        {
            myport.Write(data);
        }

        private string ClearPizzaName(string pizzaName)
        {
            return pizzaName.Replace(marioEnding, "").Substring(0, pizzaName.IndexOf('\0')) + luigiEnding;
        }

        private void BtnMarkAsReady_Click(object sender, EventArgs e)
        {
            string selectedPizza = readyPizzas.SelectedItem.ToString();
            readyPizzas.Items.Remove(selectedPizza);
            SendSignalToArduino();
            SendRemovedPizza(ClearPizzaName(selectedPizza));
        }
    }
}
