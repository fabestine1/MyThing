using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApril2018StartUp
{
    interface IBorrowable
    {
        // If it is possible to borrow it, register the name of the borrower, as indicated in the parameter, and return true. If it is not possible to borrow it, return false.
        bool Borrow(string borrower);

        // Register that it is not borrowed anymore.
        void Receive();

        // returns true when it is borrowed, returns false when it is not borrowed.
        bool IsBorrowed();
    }
}
