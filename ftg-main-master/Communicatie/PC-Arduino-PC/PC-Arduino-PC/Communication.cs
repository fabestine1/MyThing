using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Garagemanagement
{
    abstract public class Communication
    {
        private DataInterpretor reader;

        public int comID;

        private long lifetime;

        protected bool connection;

        protected bool handshaked;

        protected bool isdisconnected;

        private bool showhandshakefailmessage;

        public virtual string devicetype { get; set; }

        public string DeviceName {get; private set;}

        /// <summary>
        /// This object holds the function to deal with incoming commands
        /// </summary>
        public CommandExecution unhandledcommands;

        /// <summary>
        /// This function is attached to the device's communication channel.
        /// 
        /// It should trigger IncomingCommand_Handle()
        /// 
        /// IncomingCommand_Handle arguments: char or string
        /// </summary>
        abstract public void Device_Read();

        /// <summary>
        /// Sends an array of bytes to the device communication channels
        /// </summary>
        /// <param name="raw">bytes to send</param>
        abstract public bool Device_Send(string raw);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="devicename"></param>
        /// <param name="executable">This is a void function that will deal with the incoming commands from the communiation line</param>
        public Communication(string devicename, Action<ComData, Communication> executable)
        {
            reader = new DataInterpretor();
            comID = 0;

            UpdateLifetime();

            DeviceName = devicename;

            unhandledcommands = new CommandExecution(executable);
        }

        /// <summary>
        /// A command to determine whether the 
        /// 
        /// ion hasn't been receiving commands for too long
        /// </summary>
        /// <returns></returns>
        public bool Expired()
        {
            
            long now = (DateTime.Now.Month * 2678400 + DateTime.Now.Day * 86400 + DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second);

            //connection expires after 5 seconds..
            return ((now - lifetime) > 5);
        }

        public long Lifetime
        {
            get
            {
                return lifetime;
            }
            private set
            {
                if (value > lifetime)
                {
                    lifetime = value;
                }
            }
        }

        public bool Connected
        {
            get
            {
                return handshaked;
            }
        }

        protected void MadeConnection()
        {
            connection = true;
            Debug.WriteLine("Device `" + DeviceName + "` communication line was opened");

            Reporter.AddReport(3, DeviceName);
        }
        protected void LostConnection(string message)
        {
            connection = false;
            Debug.WriteLine("Device `" + DeviceName + "` communication line was lost");

            if(Connected && Program.MasterServer.Connected)
            {
                try
                {
                    Program.MasterServer.Server.Exit(comID);
                }
                catch(System.ObjectDisposedException)
                {
                    Debug.WriteLine("Tried to unregister but server channel was lost");
                }

                comID = 0;
                handshaked = false;

                showhandshakefailmessage = true;
            }

            Reporter.AddReport(2, this.DeviceName);
            Reporter.AddReport(4, message);
        }

        public void UpdateLifetime()
        {
            Lifetime = (DateTime.Now.Month * 2678400 + DateTime.Now.Day * 86400 + DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second);
        }

        /// <summary>
        /// Deals with processing communication channels
        /// </summary>
        /// <param name="incomingbyte">a single byte of a command</param>
        public void IncomingCommand_Handle(char incomingbyte)
        {
            reader.addChar(incomingbyte);

            UpdateLifetime();

            if(reader.usableInput)
            {
                ComData comdata = reader.getComData();
                unhandledcommands.Add(comdata, this);
            }
        }
        /// <summary>
        /// Deals with processing communication channels
        /// </summary>
        /// <param name="incomingbytes">multiple bytes of a command</param>
        public void IncomingCommand_Handle(string incomingbytes)
        {
            reader.addString(incomingbytes);

            UpdateLifetime();

            if (reader.usableInput)
            {
                ComData data = reader.getComData();
                unhandledcommands.Add(data, this);
            }
        }
        public void IncomingCommand_Handle(ComData properCommand)
        {
            unhandledcommands.Add(properCommand, this);
        }

        public bool HandShake(string devicename, string devicetype, ref int deviceID, ref int serverID, ref string ServerName, GarageServer.TrafficMessageClient Server)
        {
            string result;

            try
            {
                result = Server.Handshake(1, DeviceName + "," + devicetype);
            }
            catch
            {
                Debug.WriteLine("Handshake failed (0)");
                return false;
            }

            if (Int32.TryParse(result, out deviceID))
            {
                if (deviceID > 0)
                {
                    comID = deviceID;

                    Debug.WriteLine("Completed handshake 1");

                    result = Server.Handshake(2, comID.ToString());

                    if (result.Length > 0)
                    {
                        ServerName = result;
                        Debug.WriteLine("Completed handshake 2");

                        result = Server.Handshake(3, comID.ToString());

                        int expectedserverID;

                        if (Int32.TryParse(result, out expectedserverID))
                        {

                            if (expectedserverID > 0)
                            {
                                serverID = expectedserverID;

                                Debug.WriteLine("Completed handshake 3");

                                result = Server.Handshake(4, Program.MasterServer.comID.ToString() + "," + comID);

                                if (result == "OK")
                                {
                                    Debug.WriteLine("Completed handshake 4 - linking");
                                    MadeConnection();
                                    return true;
                                }
                                else
                                {
                                    Debug.WriteLine("Handshake failed (4)");
                                }
         
                            }
                            else
                            {
                                Debug.WriteLine("Handshake failed (3)");
                            }
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Handshake failed (2)");
                    }
                }
                else
                {
                    Debug.WriteLine("Handshake failed (1)");
                }
            }

            if (showhandshakefailmessage)
            {
                showhandshakefailmessage = false;
                Reporter.AddReport(4, "Handshake for '" + this.DeviceName + "' failed!");
            }
            return false;
        }
        
        /// <summary>
        /// Converts stringified ComData to comdata and moves it over
        /// </summary>
        /// <param name="rawcommand">A stringified ComData</param>
        /// <returns></returns>
        public bool Send(string rawcommand)
        {
            DataInterpretor reader = new DataInterpretor();

            reader.addString(rawcommand);

            if (reader.usableInput)
            {
                ComData comdata = reader.getComData();
                bool succession = Send(comdata);

                if(succession == true)
                {
                    UpdateLifetime();
                }

                return succession;
            }
            else
            {
                return false;
            }
        }
        public bool Send(ComData comdata)
        {
            bool succession = Device_Send(comdata.ToString());

            if (succession == true)
            {
                UpdateLifetime();
            }

            return succession;
        }
    }
}