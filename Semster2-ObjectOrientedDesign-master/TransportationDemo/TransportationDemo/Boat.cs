using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationDemo
{
    class Boat: Transportation
    {
        private string company;
        private int weight; 

        public Boat(string company, int weight, int speed): base(speed)
        {
            this.company = company;
            this.weight = weight;
        }

        public new string GetInfo()
        {
            return "itzzz a boattt";
        }
    }
}
