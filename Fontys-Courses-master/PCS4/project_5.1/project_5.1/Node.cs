using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._1
{
    class Node
    {
        public string Name { get; set; }
        public Node Next { get; set; }
        public Node(string name)
        {
            Name = name;
            Next = null;
        }
    }
}
