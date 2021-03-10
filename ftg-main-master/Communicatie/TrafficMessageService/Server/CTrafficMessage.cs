using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MessageService;
using System.ServiceModel;
using System.Diagnostics;

namespace Garagemanagement
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CTrafficMessage : ITrafficMessage
    {
        private List<ComData> MessagesList;
        private DataInterpretor data;

        private DeviceRouting devices;

        private Commands Commandslist;

        private int myserverID;

        /// <summary> incoming commands
        /// REGISTER_DEVICE: params: string devicename [unique], string devicetype
        ///     A call from a connected device for requesting an ID from the server
        /// 
        /// ACKNOWLEDGE: params: int acknowledged
        ///     Response to REGISTER_ACKNOWLEDGE
        ///     expected acknowledged == deviceID
        ///
        /// DEBUGLINE: string message
        ///     A call to print data to server console
        /// </summary>
        private enum Commands_SERVER { invalid, REGISTER_DEVICE, ACKNOWLEDGE, DEBUGLINE};
        /// <summary> outgoing commands
        /// REGISTER_ACKNOWLEDGE: supplied params: int deviceID
        ///     Returns the device ID gotten in response to REGISTER_DEVICE
        ///     
        /// ERROR: supplied params: int errorcode, string message
        ///     Returns a code that is associated with error handling on connected device
        ///     
        /// STILLALIVE:
        ///     A server request to send ACKNOWLEDGE from connected device
        /// 
        /// </summary>
        private enum Commands_CLIENTS { invalid, REGISTER_ACKNOWLEDGE, STILLALIVE, ERROR };

        CTrafficMessage()
        {
            MessagesList = new List<ComData>();
            data = new DataInterpretor();
            devices = new DeviceRouting();
            Commandslist = new Commands(); 

            DeviceRegistry Server = new DeviceRegistry("FTG-SERVER", "server");

            devices.Add(Server);

            myserverID = devices.FindIDByDevice(Server);
        }
        /// <summary>
        /// Perform all handshaking to give and validate ID's as well as device names
        /// </summary>
        /// <param name="step">the step it is following</param>
        /// <param name="givenvalue">any value that is supposed to be supplied per step</param>
        /// <returns></returns>
        public string Handshake(int step, string givenvalue)
        {
            if (step>0)
            {
                switch(step)
                {
                        //step 1: supplied unique devicename and type in list, requests deviceID from server
                    case 1:
                        {
                            string [] parameters = givenvalue.Split(",".ToArray(), 3);

                            if (parameters != null)
                            {
                                string devicename = parameters[0];
                                string devicetype = parameters[1];

                                if (devicename.Length > 0 && devicetype.Length > 0)
                                {

                                    if (devices.FindByName(devicename) == null)
                                    {

                                        DeviceRegistry device = new DeviceRegistry(devicename, devicetype);

                                        devices.Add(device);

                                        string deviceID = devices.FindIDByDevice(device).ToString();

                                        Console.WriteLine(device.Name + ": registered to ID '" + deviceID + "'");
                                        Console.WriteLine(DateTime.Now + " - Handshake step 1 - Device: " + devicename + " (" + deviceID + ")");
                                        
                                        return deviceID;
                                    }
                                    else
                                    {
                                        Console.WriteLine(DateTime.Now + " - Handshake step failed - Already registered Device: " + devicename);
                                    }
                                }
                            }
                            break;
                        }
                        //Step 2: supplied deviceID, requests server name
                    case 2:
                        {
                            int deviceID;
                            if (Int32.TryParse(givenvalue.ToString(), out deviceID))
                            {
                                //validate the existence of the device by id

                                if (devices.FindByID(deviceID) != null)
                                {
                                    Console.WriteLine(DateTime.Now + " - Handshake step 2 - DeviceID: " + deviceID);

                                    return devices.FindByID(myserverID).Name;
                                }
                                else
                                {
                                    Console.WriteLine(DateTime.Now + " - Handshake step failed - tried handshaking with unknown device on id '" + deviceID + "'");
                                }
                            }
                            else
                            {

                            }
                            break;
                        }
                        //supplied deviceID, requests serverID
                    case 3:
                        {
                            int deviceID;
                            if (Int32.TryParse(givenvalue.ToString(), out deviceID))
                            {

                                //validate the existence of the device by id

                                if (devices.FindByID(deviceID) != null)
                                {
                                    Console.WriteLine(DateTime.Now + " - Handshake step complete - Device: " + devices.FindByID(deviceID).Name + " (" + deviceID + ")");

                                    return myserverID.ToString();
                                }
                                else
                                {
                                    Console.WriteLine(DateTime.Now + " - Handshake step failed - tried handshaking with unknown device on id '"+deviceID+"'");
                                }
                            }
                            break;
                        }
                }
            }        
            return "";
        }
        /// <summary>
        /// Incoming messages from clientss are processed here.
        /// </summary>
        /// <param name="message">Stringified version of ComData</param>
        public void SendMessage(string message)
        {
            //Process Stringified ComData
            data.addString(message);

            //Is it really usable (as ComData)
            if (data.usableInput)
            {
                //Get the comdata
                ComData comdata = data.getComData();

                int senderID = 0;
                int receiverID = 0;
                int commandID = 0;

                string CurrentTime = DateTime.Now.ToString("HH:mm:ss");

                comdata.Get(0, ref senderID);
                comdata.Get(1, ref receiverID);
                comdata.Get(2, ref commandID);

                //Is the command valid?
                if (commandID < 1)
                {
                    MessagesList.Add(Commandslist.GenerateErrorMessage(senderID, 1, "Invalid command"));
                    return;
                }

                //A message has been received by something, find device
                DeviceRegistry receiver = devices.FindByID(receiverID);

                //The receiver has not been registered in this system
                if (receiver==null)
                {
                    //And the receiver is not supposed to be 'everyone'
                    if (receiverID != -1)
                    {
                        //then stop the code..
                        //Add the message to return error to sender
                        MessagesList.Add(Commandslist.GenerateErrorMessage(senderID, 1, "Invalid receiver"));
                        return;
                    }
                }

                //If this message is meant for this server
                if (receiverID == myserverID || receiverID == -1)
                {
                    //Does not require a valid senderID
                    //Switch base handshake commands

                    dynamic result = Commandslist.ExecuteCommand(commandID, myserverID, senderID, receiverID, comdata, devices);
                    
                    //if result is a command
                    if(result is ComData)
                    {
                        int param1=0;
                        result.Get(0, ref param1);

                        Console.WriteLine(param1);
                        Console.WriteLine(message);
                        MessagesList.Add(result);
                    }
                }
                else//wasn't meant  for this server
                {
                    //TODO make code to transmit command to target
                }
            }
            else
            {
                string CurrentTime = DateTime.Now.ToString("HH:mm:ss");
                Console.WriteLine("corrupted message received at " + CurrentTime);
            }
        }
        /// <summary>
        /// Sends a message to a client
        /// </summary>
        /// <param name="deviceID"></param>
        /// <returns></returns>
        public string RetrieveMessage(int deviceID)
        {
            ComData data;
            string message=",";

            DeviceRegistry device = devices.FindByID(deviceID);

            if (MessagesList.Count == 0 || device == null)
            {
                return "{}";
            }
            else
            {
                devices.UpdateLiveTime(deviceID);

                data = MessagesList[0];
                MessagesList.RemoveAt(0);

                int i = 0;

                while(data.GetType(i) > 0)
                {
                    string messagepiece = "";

                    data.Get(i, ref messagepiece);
                    message += messagepiece + ",";
                    i++;
                }
                message = message.Substring(0, message.Length-1);
                if (message.Length > 0)
                {
                    message = "{" + message + "}";
                }

                return message;
            }
        }
        /// <summary>
        /// Allow a PC connection to unregister itself
        /// </summary>
        /// <param name="deviceID"></param>
        public void Exit(int deviceID)
        {
            if(deviceID>-1)
            {
                DeviceRegistry device = devices.FindByID(deviceID);
                if(device!=null)
                {
                    Console.WriteLine(DateTime.Now + " - " + device.Name + ": unregistered from ID '" + deviceID + "'");
                    devices.Remove(deviceID);
                }
            }
        }
    }
}
