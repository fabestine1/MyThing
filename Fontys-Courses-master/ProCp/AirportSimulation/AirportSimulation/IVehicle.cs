using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportSimulation
{
    public interface IVehicle
    {
        int Name { get; set; }
        int Speed { get; set; }
        int Position { get; set; }
        int Capacity { get; set; }
        int BaggageCount { get; set; }

        void Move();
    }
}