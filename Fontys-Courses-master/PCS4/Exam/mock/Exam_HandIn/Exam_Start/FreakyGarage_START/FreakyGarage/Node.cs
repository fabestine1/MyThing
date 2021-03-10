using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    class Node
    {
        public Car Value { get; set; }
        public Node Next { get; set; }
        public Node(Car c)
        {
            Value = c;
            Next = null;
        }
    }
}
