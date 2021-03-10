using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._1
{
    class Car
    {
        private string model;
        private int speed;
        private double fuel;

        public int Speed
        {
            get { return speed; }
            private set {
                if (value >= 0 && value <= 260)
                {
                    speed = value;
                }
            }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            private set {
                if (value >= 0 && value <= 50)
                {
                    fuel = value;
                }
            }
        }
        public void Refuel(double tanked)
        {
            Fuel = tanked;
        }
        public void Accelerate()
        {
            Speed += 10;
            if(Fuel == 0)
            {
                Speed = 0;
            }
        }
        public void Break()
        {
            Speed -= 10;
            if (Fuel == 0)
            {
                Speed = 0;
            }
        }
    }
}
