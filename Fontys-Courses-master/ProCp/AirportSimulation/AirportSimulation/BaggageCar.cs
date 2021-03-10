using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportSimulation
{
    public class BaggageCar : IVehicle
    {
        public BaggageCar()
        {
            throw new System.NotImplementedException();
        }

        public int StartingPosition { get; set; }

        public int Name { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; }
        public int Capacity { get; set; }
        public int BaggageCount { get; set; }
        public void Move()
        {
            throw new NotImplementedException();
        }

        public void unloadBaggage()
        {
            throw new System.NotImplementedException();
        }
    }
}