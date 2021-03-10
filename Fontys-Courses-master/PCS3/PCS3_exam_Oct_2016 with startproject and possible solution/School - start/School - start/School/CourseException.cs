using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class CourseException : Exception
    {
        public CourseException(string message) : base(message) { }
    }
}
