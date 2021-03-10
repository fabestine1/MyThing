using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4._2_and_4._3
{
    class MarkOutOfRangeException:Exception
    {
        public MarkOutOfRangeException()
            : base() { }
        public MarkOutOfRangeException(string message)
            : base(message) { }
    }
}
