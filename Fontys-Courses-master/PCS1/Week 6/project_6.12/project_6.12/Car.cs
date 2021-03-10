using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._12
{
    class Car
    {
        public string model;
        public int speed;
        public int step;

        public void Accelerate()
        {
            speed += step;
        }
        public void Break()
        {
            speed -= step;
        }
    }
}
