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
    class Arduino : Communication
    {
        public SerialPort Board;

        private string buffer;
        private bool opened;

        public bool IsOpen { get; private set; }

        public string ComPort { get { return Board.PortName; } }
        public int BaudRate { get { return Board.BaudRate; } }

        private Timer connectionTimer;
        private Timer readTimer;
        //TODO Replace pesky connectionTimer with handshakes (let the arduino respond with command 1)
        //ELSE, enable testConnection until connection was made
        public Arduino(string comport, int baudrate)
        {
            bool success = false;

            connectionTimer = new System.Timers.Timer(2000);
        // Hook up the Elapsed event for the timer. 
            connectionTimer.Elapsed += checkConnection;
            connectionTimer.Enabled = false;

            readTimer = new System.Timers.Timer(20);
            // Hook up the Elapsed event for the timer. 
            readTimer.Elapsed += performRead;
            readTimer.Enabled = false;

            //if no comport (length = 0) is given, select one that is available and not in use
            if (comport.Length==0)
            {
                //loop each available comport and try to connect
                foreach (string s in SerialPort.GetPortNames())
                {
                    //initialise SerialPort object
                    Board = new SerialPort(s, baudrate);
                    //note, objects are garbage collected when no reference exists to it..
                    //SerialPort object is automatically disposed of when no connection is possible

                    //check condition of communication line
                    if (TestConnection())
                    {
                        success = true;
                        break;
                    }
                }
                //NOTE: success will stay false when no comport is available or no good connnection can be made
            }
            else
            {
                Board = new SerialPort(comport, baudrate);

                //check condition of communication line
                if (TestConnection())
                {
                    success = true;
                }
            }
            if(!success)
            {
                Debug.Write("ERROR: Could not establish connection.");
            }

        }
        ~Arduino()
        {
            if (Board.IsOpen)
            {
                try
                {
                    Board.Close();
                }
                catch(System.IO.IOException)//already closed or comport no longer exists
                {

                }
                
            }
        }

        private void checkConnection(Object source, ElapsedEventArgs e)
        {
            TestConnection();
        }
        private void performRead(Object source, ElapsedEventArgs e)
        {
            Read();
        }

        public bool TestConnection()
        {
            //try following code and catch exception/mistake
            try
            {
                /* Why open close and open
                 * 
                 * When a comport does not respond, it will keep its connection available.
                 * This makes the computer think the connection is still proper
                 * By closing an existing comport and reopening will fail when the comport or device on comport is non-responsive.
                 * /

                /* open comport if not already open
                 * 
                 * Will fail when comport is not available
                 * Will fail when comport is not responsive
                */
                if (!Board.IsOpen)
                {
                    Board.Open();
                }

                /*close the comport
                 * 
                 * Will fail when comport is no longer available
                 */               
                Board.Close();

                /* open comport
                 * 
                 * Will fail when comport is not available
                 * Will fail when comport is not responsive
                */
                Board.Open();

                IsOpen = true;
                readTimer.Enabled = true;
                return true;
            }
            catch
            {

                /*may fail upon following conditions:
                 * - Communication line (COMPORT) does not exist
                 * - Communication line (COMPORT) is already in use
                 * - Device on other end has frozen during intialisation (TIMEOUT)
                 */
                IsOpen = false;
                readTimer.Enabled = false;
                return false;
            }
        }

        public bool Send(int sendInt, string sendString)
        {
            if (Board.IsOpen)
            {
                try
                {
                    Board.Write("{d" + sendInt + "," + sendString + "}");
                }
                catch (System.IO.IOException)
                {
                    Board.Close();
                }
                return true;
            }
            else
            {
                Debug.Write("ERROR: Could not establish connection.");
                return false;
            }
        }

        public void Read()
        {
            if (Board.IsOpen && Board.BytesToRead > 0)
            {
                try
                {
                    char incomingByte = (char)Board.ReadByte();

                    if (incomingByte == '{')
                    {
                        opened = true;
                    }
                    else if (incomingByte == '}')
                    {
                        opened = false;
                        String bufferx = buffer;
                        buffer = "";

                        Debug.Write(bufferx);
                        
                    }
                    else if (opened)
                    {
                        buffer += incomingByte;
                    }
                }
                catch
                {
                    Debug.Write("Could not read the incomming message\n");
                }
            }
        }
    }
}
