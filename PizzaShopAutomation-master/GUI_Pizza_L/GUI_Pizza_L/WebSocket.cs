using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI_Pizza_L
{
    class WebSocket
    {
        // Declaring a Net Socket object
        public Socket sck;
        // Declaring 2 Endpoints objects for 2 pcs
        public EndPoint epLocal, epRemote;

        // An array to holds the message 
        byte[] buffer;


        // this list stores all the messages 
        public List<string> messages;

        //constructore
        public WebSocket()
        {
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            messages = new List<string>();


        }



        //methods
        public void connect(string LIP, string LPort, string RIP, string RPort)
        {
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(LIP), Convert.ToInt32(LPort));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(RIP), Convert.ToInt32(RPort));
            sck.Connect(epRemote);
            //start the connection 
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
        // A method to get your IP address from DNS server
        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";

        }
        public void sendMsg(string msg)
        {
            // convert string msg to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(msg);
            messages.Add(msg);
            // send the msg
            sck.Send(sendingMessage);
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //converting byte[] to string

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);


                //add to list 
                messages.Add(receivedMessage);
                //messages.Add("Friend " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
