using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._3
{
    class Car
    {
        public string model;
        public int startingspeed;

        public void Accelerate()
        {
            startingspeed += 10;
        }
        public void Break()
        {
            startingspeed -= 10;
        }
    }
}
