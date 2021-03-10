using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxStore
{
    class Node
    {
        public Song Song { get; set; }
        public Node Next { get; set; }
        public Node(Song s)
        {
            Song = s;
            Next = null;
        }
    }
}
