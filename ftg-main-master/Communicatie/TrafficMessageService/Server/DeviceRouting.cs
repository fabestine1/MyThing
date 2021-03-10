using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Garagemanagement
{
    public class DeviceRouting
    {
        private List<DeviceRegistry> devices;
        private List<int> routes;
        private List<long> livetimes;

        private Timer livetimeTimer;

        public DeviceRouting()
        {
            devices = new List<DeviceRegistry>();
            devices.Add(null); //this is the invalid index
            routes = new List<int>();
            livetimes = new List<long>();

            livetimes.Add(0);
            routes.Add(-1);

            livetimeTimer = new Timer(100);

            livetimeTimer.Elapsed += livetimeTimer_Elapsed;
            livetimeTimer.Enabled = true;
        }

        public bool Add(DeviceRegistry device)
        {
            if (FindByName(device.Name) != null)
            {
                return false;
            }
            else
            {
                devices.Add(device);
                livetimes.Add(-1);
                routes.Add(-1);
                return true;
            }
        }

        public bool Remove(DeviceRegistry device)
        {
            if (device == null)
            {
                return false;
            }
            else
            {
                return Remove(FindIDByDevice(device));
            }
        }

        public bool Remove(int deviceID)
        {
            if (FindByID(deviceID) != null)
            {
                if(deviceID==(devices.Count -1))
                {
                    devices.RemoveAt(deviceID);
                    livetimes.RemoveAt(deviceID);
                    routes.RemoveAt(deviceID);
                }
                else
                {
                    devices[deviceID]=null;
                    livetimes[deviceID]=0;
                    routes.RemoveAt(-1);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public DeviceRegistry FindByName(string name)
        {
            if (name.Length > 0)
            {
                foreach (DeviceRegistry device in devices)
                {
                    if (device != null)
                    {
                        if (device.Name == name)
                        {
                            return device;
                        }
                    }
                }
            }


            return null;
        }

        public int FindIDByDevice(DeviceRegistry device)
        {
            if (device != null)
            {
                return devices.IndexOf(device);
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Finds all devices that are of a certain type
        /// Will return List<DeviceRegistry> if a result is found.
        /// Will return null when no results are found.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<DeviceRegistry> FindByType(string type)
        {
            if(!ValidateType(type))
            {
                return null;
            }
            else
            {
                List<DeviceRegistry> resultlist = new List<DeviceRegistry>(); 
                type = type.ToLower();
                foreach (DeviceRegistry device in devices)
                {
                    if (device != null)
                    {
                        if (device.Type == type)
                        {
                            resultlist.Add(device);
                        }
                    }
                }

                if(resultlist.Count==0)
                {
                    return null;
                }
                else
                {
                    return resultlist;
                }
            }
        }

        public DeviceRegistry FindByID(int deviceID)
        {
            try
            {
                return devices.ElementAt(deviceID);
            }
            catch
            {
                return null;
            }
            
        }
        public bool ValidateType(string type)
        {
            if (type==null)
            {
                return false;
            }
            type = type.ToLower();
            switch(type)
            {
                case "processor":
                case "pc":
                case "i/o":
                case "server":
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
        public bool UpdateLiveTime(int deviceID)
        {
            try
            {
                livetimes.ElementAt(deviceID);//will throw error if out of range or not existing
            }
            catch
            {
                return false;
            }

            long ticks = DateTime.UtcNow.Ticks - DateTime.Parse("01/01/1970 00:00:00").Ticks;
            ticks /= 10000000; //Convert windows ticks to seconds
            livetimes[deviceID] = ticks;
            return true;
        }

        private void livetimeTimer_Elapsed(Object source, ElapsedEventArgs e)
        {
            int index = 0;
            long now = DateTime.Now.Ticks;
            foreach(DeviceRegistry device in devices)
            {
                if(device != null)
                {
                    if(now - device.StayAliveTime > 10)
                    {

                    }
                }
                index++;
            }
        }
    }
}
