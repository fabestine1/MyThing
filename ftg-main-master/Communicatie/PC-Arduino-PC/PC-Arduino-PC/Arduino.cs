using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Garagemanagement
{
    /// <summary>
    /// This class deals with connecting with an arduino and communication with it
    /// </summary>
    class Arduino : Communication
    {
        /// <summary>
        /// The SerialPort object deals with initialising and communicating with COMPORTS
        /// </summary>
        public SerialPort Board;
        /// <summary>
        /// This variable is used to determine whether the Arduino is connected or not
        /// </summary>
        public bool IsOpen { get; private set; }

        /// <summary>
        /// A reference to the PORT the Arduino is connected to
        /// </summary>
        public string ComPort
        {
            get
            {
                if (Board == null)
                {
                    return "";
                }
                else
                {
                    return Board.PortName;
                }
            }
        }
        /// <summary>
        /// A reference to the PORT's baudrate the Arduino is connected to
        /// </summary>
        public int BaudRate
        {
            get
            {
                if (Board == null)
                {
                    return 0;
                }
                else
                {
                    return Board.BaudRate;
                }
            }
        }

        /// <summary>
        /// Potential values:
        /// NULL, "", COM#
        /// </summary>
        private string TargetComPort;


        private int TargetBaudRate;

        /// <summary>
        /// Timer used to determine the connection and remake connection if it was lost
        /// </summary>
        private Timer connectionTimer;

        /// <summary>
        /// Timer to read incoming data from
        /// </summary>
        private Timer readTimer;

        override public string devicetype { get; set; }


        public Arduino(string devicename, string comport, int baudrate, Action<ComData,Communication> executable)
            : base(devicename, executable)
        {
            //define base variables
                //Setup timer that checks comport connection
                connectionTimer = new System.Timers.Timer(500);
                // Hook up the Elapsed event for the timer. 
                connectionTimer.Elapsed += checkConnectionTimer;
                connectionTimer.Enabled = true;

                //Setup timer to perform read events from
                readTimer = new System.Timers.Timer(10);
                // Hook up the Elapsed event for the timer. 
                readTimer.Elapsed += performRead;
                readTimer.Enabled = false;

                devicetype = "Arduino";//static

                if (comport != null)
                {
                    if(comport.Length>0)
                    {
                        comport = comport.ToUpper();

                        Console.WriteLine(comport.Substring(0, 3));

                        if(comport.Substring(0,3) == "COM")
                        {
                            int comportnumber = 0;

                            if (!Int32.TryParse(comport.Substring(3), out comportnumber) || comportnumber < 1)
                            {
                                throw new ArgumentException("Used invalid comport value `" + comport + "` for parameter", "comport");
                            }
                        }
                    }
                }
                
                TargetComPort = comport;
                TargetBaudRate = baudrate;

                checkConnection();
        }
        ~Arduino()
        {
            if (Program.MasterServer.Connected && Connected)
            {
                Program.MasterServer.Server.Exit(comID);
            }


            if (Board != null)//if a connection was made at least once
                if (Board.IsOpen)//and the connection is seen to be open
                {
                    //will fail when comport has been unregistered (by pulling the plug!)
                    try
                    {
                        Board.Close();
                    }
                    // Catch in case port is closed or no longer exists
                    catch (System.IO.IOException)
                    {
                        Debug.WriteLine("ERROR: Could not connect to arduino");

                    }
                }
        }

        private void checkConnectionTimer(Object source, ElapsedEventArgs e)
        {
            checkConnection();
        }

        /// <summary>
        /// Returns the state of the connection and tries to connect if possible
        /// </summary>
        /// <returns>True when the connection is valid;False when connection doesn't seem valid</returns>
        public bool checkConnection()
        {
            if(TestConnection())
            {
                if (Program.MasterServer.Connected && !Connected)
                {

                    int deviceID = 0;
                    int serverid = 0;
                    string servername = "";

                    if (HandShake(this.DeviceName, devicetype, ref deviceID, ref serverid, ref servername, Program.MasterServer.Server))
                    {
                        if (Send("{0,0,2," + serverid + "," + comID + "}"))
                        {
                            comID = deviceID;

                            handshaked = true;

                            Reporter.AddReport(4, "Handshake for '" + this.DeviceName + "' succeeded!");

                            isdisconnected = false;
                            return true;
                        }
                    }
                    else
                    {
                        if (!isdisconnected)
                        {
                            isdisconnected = true;

                            Reporter.AddReport(4, "Handshake for '" + this.DeviceName + "' failed");
                        }
                    }
                }
                return true;
            }
            else
            {
                if(Board != null)
                {
                    LostConnection("Disconnected '" + this.DeviceName + "' from `" + this.ComPort + "`");
                    Board = null;
                    readTimer.Enabled = false;
                }
            }

            //if no comport (length = 0) is given, select any comport that is available and not in use
            if (TargetComPort == null || TargetComPort.Length == 0)
            {
                //loop each available comport and try to connect
                foreach (string s in SerialPort.GetPortNames())
                {
                        bool success = makeconnection(s, TargetBaudRate);
                        if (success == true)
                        {
                            break;
                        }
                }
                //NOTE: success will stay false when no comport is available or no good connnection can be made
            }
            else //A COMPORT is specified
            {
                //define SerialPort object
                makeconnection(TargetComPort, TargetBaudRate);            
            }

            if (Board == null)
            {
                Debug.WriteLine("ERROR: Could not establish connection.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool makeconnection(string COMID, int baudrate)
        {
            if (Board != null)
            {
                if (Board.IsOpen)
                {
                    return true;
                }
            }

            //no board comport connection is made
            Board = new SerialPort(COMID, baudrate);

            try
            {
                Board.Open();
            }
            catch
            {
                return false;
            }

            //check condition of communication line
            if (TestConnection())
            {
                Reporter.AddReport(1, "\'" + this.DeviceName + "\'," + this.ComPort + "," + this.BaudRate.ToString());

                Reporter.AddReport(4, "Arduino `" + this.DeviceName + "` connected on port " + this.ComPort + ", baudrate" + this.BaudRate.ToString());

                readTimer.Enabled = true;

                MadeConnection();

                return true;
            }
            Board = null;
            return false;
        }

        private void performRead(Object source, ElapsedEventArgs e)
        { 
            Device_Read();
        }

        public bool TestConnection()
        {
            if (Board != null)
            {
                if (Board.IsOpen)
                {
                    if (Device_Send(" "))
                    {
                        UpdateLifetime();
                        return true;
                    }
                    else
                    {
                        @Board.Close();
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// The actual function that writes to the Arduino's communication channel
        /// </summary>
        /// <param name="stringdata">Text to print</param>
        /// <returns>true on success, false on fail</returns>
        public override bool Device_Send(string raw)
        {
            //the comport is detected as open
            if (Board.IsOpen)
            {
                Debug.WriteLine("Trying to send to '" + DeviceName + "': " + raw);
                try
                {
                    Board.Write(raw);//try to write to board
                }
                //whoops, something went wrong
                catch (System.IO.IOException)
                {
                    Debug.WriteLine("ERROR: Could not send to Arduino, IOException");
                    try
                    {
                        //try to close, will succeed when port hasn't suddenly dissapeared
                        Board.Close();
                    }
                    catch (System.IO.IOException)
                    {
                        //Port went missing..
                    }
                    return false;
                }
                return true;
            }
            else
            {
                //can't send
                Debug.WriteLine("ERROR: Connection is closed");
                return false;
            }
        }
        /// <summary>
        /// Reads data from Arduino's communication channels
        /// </summary>
        public override void Device_Read()
        {
            //if there is something to read
            if (Board.IsOpen)
            {
               string incomingdata = "";

                try
                {
                    incomingdata = Board.ReadExisting();
                }
                catch//problem occured..
                {
                    checkConnection();
                    Debug.WriteLine("ERROR: Could not read incoming byte");
                }

                if (incomingdata.Length > 0)
                {
                    IncomingCommand_Handle(incomingdata);
                }
            }
        }
    }
}
