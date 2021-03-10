using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


///<summary>
///  The class that contains 'routing' data
///</summary>
namespace Garagemanagement
{
    public class DeviceRegistry
    {
        public string Name {get; private set;}

        /// <summary>
        /// Types:
        /// </summary>
        public string Type { get; private set; }

        private long stayalivetime;
        public long ValidationSteps { get; set; }
        public long StayAliveTime
        {
            get
            { return stayalivetime; }
            set
            {
                if (value > stayalivetime)
                {
                    stayalivetime = value;
                }
            }
        }

        public DeviceRegistry(string name, string type)
        {
            if (type==null)
            {
                throw new ArgumentException("Invalid type given (" + type + ")", "type");
            }
            type = type.ToLower();
            switch(type)
            {
                case "processor":
                case "pc":
                    {
                        type = "processor";
                        break;
                    }
                case "arduino":
                case "i/o":
                    {
                        type = "i/o";
                        break;
                    }
                case "server":
                    {
                        break;
                    }
                default:
                {
                    throw new ArgumentException("Invalid type given ("+type+")", "type");
                }
            }
            if(name.Length==0)
            {
                throw new ArgumentException("Invalid device name given", "name");
            }

            Name = name;
            Type = type;

            stayalivetime = 0;
            ValidationSteps = 0;
        }
    }
}
