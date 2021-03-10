using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingFedApp
{
    class Node
    {
        public Racer Value { get; set; }
        public Node Next { get; set; }
        public Node(Racer i)
        {
            Value = i;
            Next = null;
        }
    }
}
