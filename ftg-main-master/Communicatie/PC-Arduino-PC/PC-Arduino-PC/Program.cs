using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Garagemanagement
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// 
    static class Program
    {

        private static Arduino mega;
        //private static Arduino mega2;
        public static PCconnectionHandler MasterServer;//our lifeline to the master server
        public static ControlPanel masterform;

        public static List<List<object>> instructions;

        public static List<Communication> LocalDevices {get; private set;}

        [STAThread]
        static void Main()
        {
            LocalDevices = new List<Communication>();
            instructions = new List<List<object>>();

        
            //create the functions to handle incoming commands by
            Action<ComData, Communication> PCCommandHandle =
            delegate(ComData incomingcommand, Communication handler)
            {
                int commandID = 0;
                incomingcommand.Get(2, ref commandID);

                switch (commandID)
                {
                    case 3:
                        {
                            string message = "";
                            incomingcommand.Get(3, ref message);

                            string message2 = "";
                            incomingcommand.Get(4, ref message2);

                            string message3 = "";
                            incomingcommand.Get(4, ref message3);

                            if (message.Length > 0)
                            {
                                Reporter.AddReport(4, handler.DeviceName + ": " + message);
                            }
                            if (message2.Length > 0)
                            {
                                Reporter.AddReport(4, handler.DeviceName + ": " + message2);
                            }
                            if (message3.Length > 0)
                            {
                                Reporter.AddReport(4, handler.DeviceName + ": " + message3);
                            }
                            break;
                        }
                    case 4:
                        {

                            string CODE = "";
                            string name = "";
                            string balance = "";
                            string parkingspot = "";
                            string amountdue = "";
                            string timestamp = "";


                            incomingcommand.Get(3, ref CODE);
                            incomingcommand.Get(4, ref name);
                            incomingcommand.Get(5, ref balance);
                            incomingcommand.Get(6, ref parkingspot);
                            incomingcommand.Get(7, ref amountdue);
                            incomingcommand.Get(8, ref timestamp);

                            List<object> instructionparams = new List<object>();

                            instructionparams.Add("CHIPFOUND");
                            instructionparams.Add(CODE);
                            instructionparams.Add(name);
                            instructionparams.Add(balance);
                            instructionparams.Add(parkingspot);
                            instructionparams.Add(amountdue);
                            instructionparams.Add(timestamp);

                            instructions.Add(instructionparams);

                            Reporter.AddReport(4, "NFC Chip found: " + CODE);

                            break;
                        }
                }
            };

            Action<ComData, Communication> ArduinoCommandHandle =
            delegate(ComData incomingcommand, Communication handler)
            {

                int commandID = 0;
                incomingcommand.Get(2, ref commandID);

                switch (commandID)
                {
                    case 3:
                        {
                            string message = "";
                            incomingcommand.Get(3, ref message);

                            string message2 = "";
                            incomingcommand.Get(4, ref message2);

                            string message3 = "";
                            incomingcommand.Get(4, ref message3);

                            if (message.Length > 0)
                            {
                                Reporter.AddReport(4, handler.DeviceName + ": " + message);
                            }
                            if (message2.Length > 0)
                            {
                                Reporter.AddReport(4, handler.DeviceName + ": " + message2);
                            }
                            if (message3.Length > 0)
                            {
                                Reporter.AddReport(4, handler.DeviceName + ": " + message3);
                            }
                            break;
                        }
                }
            };

            mega = new Arduino("Garage I/O", "", 19200, ArduinoCommandHandle);
            //mega2 = new Arduino("ChipSCan", "", 19200, ArduinoCommandHandle);

            MasterServer = new PCconnectionHandler("TEST", PCCommandHandle);

            LocalDevices.Add(mega);
            //LocalDevices.Add(mega2);
            LocalDevices.Add(MasterServer);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            masterform = new ControlPanel();

            Application.Run(masterform);
        }
    }
}
