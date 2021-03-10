using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationDemo
{
    class Bicycle: Transportation
    {
        private bool hasLuggageCarrier;
        public Bicycle(bool hasLuggageCarrier, int speed): base(speed)
        {
            this.hasLuggageCarrier = hasLuggageCarrier;
        }
    }
}
