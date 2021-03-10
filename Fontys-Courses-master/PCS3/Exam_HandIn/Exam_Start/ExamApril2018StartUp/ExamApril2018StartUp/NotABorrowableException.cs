using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApril2018StartUp
{
    class NotABorrowableException : Exception
    {
        public NotABorrowableException() : base() { }
        public NotABorrowableException(string message) : base(message) { }
    }
}
