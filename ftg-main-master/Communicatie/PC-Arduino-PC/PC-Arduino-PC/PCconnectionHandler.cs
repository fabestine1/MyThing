using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;

namespace Garagemanagement
{
    /// <summary>
    /// This class deals with communication with a master server
    /// </summary>
    class PCconnectionHandler : Communication
    {
        private static Timer TimerGetMessage;

        private string servername;

        private bool tryconnecting;

        override public string devicetype { get; set; }


        public int serverID;
        public string ServerName
        {
            get
            {
                return servername;
            }
            private set
            {
                if (value != null)
                {
                    if (value.Length == 0)
                    {
                        OldServerName = servername;
                        serverID = 0;
                    }

                    servername = value;
                }
            }
        }

        public string OldServerName {get; private set;}

        private GarageServer.TrafficMessageClient server;
        public GarageServer.TrafficMessageClient Server
        {
            get
            {
                return server;
            }
            set
            {
                handshaked = false;
                server = value;
            }
        }

        public PCconnectionHandler(string devicename, Action<ComData, Communication> executable)
            : base(devicename, executable)
        {
            TimerGetMessage = new System.Timers.Timer(500);

            TimerGetMessage.Elapsed += TimerGetMessageFunction;

            TimerGetMessage.Enabled = true;

            servername = "";
            ServerName = "";

            isdisconnected = true;
            devicetype = "PC";
        }

        ~PCconnectionHandler()
        {
            if (Connected)
            {
                if (comID > -1)//if connected on ID
                {
                    server.Exit(comID);//unregister command
                }
            }
        }

        public bool Connect()
        {
            if (!tryconnecting && !Connected)
            {
                if (Server == null)
                {
                    tryconnecting = true;

                    Server = new GarageServer.TrafficMessageClient();

                    if (Server != null)
                    {
                        if(!DoHandShake())
                        {
                            Server = null;
                            ServerName = "";
                            tryconnecting = false;
                        }
                    }
                }
            }
            return false;
        }

        private bool DoHandShake()
        {
            int deviceID = 0;
            int serverid = 0;
            string servername = "";

            if (HandShake(DeviceName, devicetype, ref deviceID, ref serverid, ref servername, Server))
            {
                serverID = serverid;
                comID = deviceID;
                ServerName = servername;

                handshaked = true;

                tryconnecting = false;

                Reporter.AddReport(1, "\'" + this.DeviceName + "\', " + this.ServerName);
                Reporter.AddReport(4, devicetype + " connected '" + this.DeviceName + "' to `" + this.ServerName + "`");
                Reporter.AddReport(4, "Handshake for '" + this.DeviceName + "' succeeded!");

                isdisconnected = false;

                return true;

            }
            else
            {
                if (!isdisconnected)
                {
                    isdisconnected = true;

                    LostConnection("Disconnected '" + this.DeviceName + "' from `" + this.ServerName + "`");
                }

                Server = null;
                return false;
            }
        }

        public override bool Device_Send(string raw)
        {
            if (Connected)
            {
                Console.WriteLine("Trying to send to '" + DeviceName + "': " + raw);
                server.SendMessage(raw);
                return true;
            }
            else
            {
                Debug.WriteLine("ERROR: Could not send to Server, not connected");
                return false;
            }  
        }
        /// <summary>
        /// Just an implementation of the communication class, no need to actually use it
        /// Read function is dealt with by TimerRefresh
        /// </summary>
        public override void Device_Read()
        {

        }
        /// <summary>
        /// The following function is in charge of trying to connect to the server.
        /// If it is connected, try to get messages from the server
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void TimerGetMessageFunction(Object source, ElapsedEventArgs e)
        {
            if (Connected)
            {
                string message = "";
                //will fail when server connection suddenly is lost
                try
                {
                    message = server.RetrieveMessage(comID);
                }
                catch
                {
                    //so server connection is lost, reset server
                    Server = null;
                    Debug.WriteLine("ERROR: Communication to server is lost");
                    return;
                }
                   
                if (message.Length > 0)//if there is a message
                {
                    if (message != "{}")//if there ARE messages
                    {
                        IncomingCommand_Handle(message);
                    }
                }
            }
            else
            {
                //try to connect...
                Connect();
            }
        }
    }
}
