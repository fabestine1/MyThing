using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    class Car
    {
        public string model;
        public int startingspeed;

        public void ChangeSpeed(int speed)
        {
            startingspeed = speed;
        }
    }
}
