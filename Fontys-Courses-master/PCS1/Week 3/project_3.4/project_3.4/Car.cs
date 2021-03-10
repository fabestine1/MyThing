using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._4
{
    class Car
    {
        public string model;
        public string colour;
        public int startingspeed;
        public int productionyear;
        public int step;

        public void Accelerate()
        {
            startingspeed += step;
        }
        public void Break()
        {
            startingspeed -= step;
        }
    }
}
