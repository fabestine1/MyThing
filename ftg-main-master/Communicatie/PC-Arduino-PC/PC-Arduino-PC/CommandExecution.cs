using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garagemanagement
{
    public class CommandExecution
    {
        private Action<ComData, Communication> executable;

        public CommandExecution(Action<ComData, Communication> executable)
        {
            if (executable==null)
            {
                throw new ArgumentNullException("Expected function, found null", "executable");
            }

            this.executable = executable;
        }

        public void Add(ComData data, Communication handler)
        {

            if (!Program.MasterServer.Connected)//Then if connection with master server is there
            {
                return;
            }

            int target = 0;
            data.Get(0, ref target);

            int sender = 0;
            data.Get(1, ref sender);

            int commandid = 0;
            data.Get(2, ref commandid);

            //Reporter.AddReport(4, handler.DeviceName+ ": "+ data.ToString());

            switch(handler.devicetype.ToLower())
            {
                case "arduino":
                case "i/o":
                    {          
                        if(target == -1 || target == Program.MasterServer.serverID)
                        {
                            Program.MasterServer.Send(data);
                            return;
                        }
                        else if (target == handler.comID || sender == handler.comID)//coming or going from device
                        {
                            executable(data, handler);
                        }

                        if (target == handler.comID)
                        {
                            if (commandid != 3 || target != sender)
                            {
                                handler.Send(data);
                            }
                        }
                        break;
                    }
                case "server":
                case "pc":
                    {

                        if (target == -1)//is -1 when 
                        {
                            foreach (Communication device in Program.LocalDevices)
                            {
                                if (device.Connected)
                                {
                                    data.Set(0, device.comID);
                                    device.unhandledcommands.executable(data, device);
                                }
                            }
                        }
                        else if(target == handler.comID)
                        {
                            executable(data, handler);
                        }
                        else
                        {
                            foreach (Communication device in Program.LocalDevices)
                            {
                                if (device.Connected && target == device.comID)
                                {
                                    device.unhandledcommands.executable(data, device);
                                }
                            }
                        }
                                                
                        break;
                    }
            }
        }
    }
}
