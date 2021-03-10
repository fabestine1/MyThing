using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._2
{
    class MarkOutOfRangeException : Exception
    {
        public MarkOutOfRangeException() : base("Mark value is out of range.")
        {

        }
    }
}
