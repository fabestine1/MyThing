using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class Node
    {
        public string Player { get; set; }
        public int WonTimes { get; set; }
        public Node Next { get; set; }
        public Node(string i)
        {
            Player = i;
            WonTimes = 1;
            Next = null;
        }
        public override string ToString()
        {
            return "Participant " + Player + " won " + WonTimes + " times.";
        }
    }
}
