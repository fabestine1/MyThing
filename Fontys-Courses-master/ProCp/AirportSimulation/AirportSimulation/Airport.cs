using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportSimulation
{
    public class Airport
    {
        public Airport(Statistics statistics)
        {
            throw new System.NotImplementedException();
        }
        
        public List<Airplane> NumberOfAirplanes { get; set; }

        public List<BaggageCar> NumberOfBaggageCars { get; set; }

        public int AirportName { get; set; }
        
        public BaggageStorage BaggageStorage { get; set; }

        public Statistics PlanesLanded { get; set; }
    }
}