using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportSimulation
{
    public class Statistics
    {
        private int planesLanded;
        private int baggageUnloaded;
        private int planesDelayed;
        private int currentWeather;

        public Statistics()
        {
                
        }
        public int BaggageUnloaded
        {
            get => default(int);
            set
            {
            }
        }

        public int PlanesDelayed
        {
            get => default(int);
            set
            {
            }
        }

        public int PlanesLanded
        {
            get => default(int);
            set
            {
            }
        }

        public int CurrentWeather
        {
            get => default(int);
            set
            {
            }
        }

        public void getInformation()
        {
            throw new System.NotImplementedException();
        }
    }
}