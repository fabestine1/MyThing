using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationDemo
{
    class Transportation
    {
        protected int speedKMH;

        public Transportation(int speedKMH)
        {
            this.speedKMH = speedKMH;
        }

        public double CalculateHoursTillDestination(int km)
        {
            return km/speedKMH;
        }

        public string GetInfo()
        {
            return "Transportation" + speedKMH;
        }
    }
}
