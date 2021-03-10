using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garagemanagement
{
    class Commands
    {
        private List<Func<int, int, int, int, ComData, DeviceRouting, dynamic>> commandlist;
        private List<string> commandnames;

        public Commands()
        {
            commandlist = new List<Func<int, int, int, int, ComData, DeviceRouting, dynamic>>();
            commandnames = new List<string>();
            
            Add(null, null);//invalid commandID, reserved

            Add("debug", debug);
        }

        public dynamic ExecuteCommand(int commandID, int myserverID, int senderID, int receiverID, ComData comdata, DeviceRouting devices)
        {
            if(commandID<1)
            {
                return null;
            }

            Func<int, int, int, int, ComData, DeviceRouting, dynamic> f = null;
            try
            {
                f = commandlist.ElementAt(commandID);
            }
            catch
            {
                return null;
            }

            if (f == null) return null;

            return f(commandID, myserverID, senderID, receiverID, comdata, devices);
        }

        public bool Add(string funcname, Func<int, int, int, int, ComData, DeviceRouting, dynamic> function)
        {
            if (funcname != null && funcname.Length==0)
            {
                funcname = null;
            }

            commandlist.Add(function);
            commandnames.Add(funcname);
            return true;
        }
        // <summary>
        // The following commands are internally used in the server
        // </summary>

        public dynamic debug(int commandID, int myserverID, int senderID, int receiverID, ComData comdata, DeviceRouting devices)
        {

            string CurrentTime = DateTime.Now.ToString("HH:mm:ss");

            DeviceRegistry sender = devices.FindByID(receiverID);
            if (sender != null)
            {//has sender that is acknowledged by the server
                {
                    string message1 = "";
                    comdata.Get(3, ref message1);

                    string message2 = "";
                    comdata.Get(4, ref message2);


                    Console.WriteLine("'" + sender.Name + "' at " + CurrentTime + ": " + message1 + '\n' + message2);
                }
            }
            else
            {

                Console.WriteLine("Incoming command doesn't have proper sender at " + CurrentTime);
            }
            return null;
        }

        public ComData GenerateErrorMessage(int originalsender, int errorcode, string message)
        {
            ComData error = new ComData();

            //set the sender ID
            error.Set(0, 1);//1 = server

            //set the receiverID
            error.Set(1, originalsender);

            //set the corresponding command ID so it can be interpreted as 'error/warning'
            error.Set(2, 2);

            //supply error code
            if (errorcode < 0)
            {
                errorcode = 0;
            }
            error.Set(3, errorcode);

            //supply message
            if (message != null && message.Length > 0)
            {
                error.Set(4, message);
            }

            return error;
        }
    }
}
