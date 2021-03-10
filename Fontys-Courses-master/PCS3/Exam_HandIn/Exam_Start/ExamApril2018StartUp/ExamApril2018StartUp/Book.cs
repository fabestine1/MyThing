using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApril2018StartUp
{
    class Book : Readable, IBorrowable
    {
        //fields
        private string borrower = "";
        private int borrowers;

        //properties
        public string Author { get; }

        //constructors
        public Book(int id, string title, string author) : base(id, title)
        {
            Author = author;
        }

        //methods
        public string Borrower
        {
            get
            {
                return borrower;
            }
            set
            {
                borrower = value;
            }
        }
        public int Borrowers
        {
            get
            {
                return borrowers;
            }
        }

        //methods
        public override string ToString()
        {
            string holder = "Book" + base.ToString() + " Author: " + Author + ",";
            if (IsBorrowed())
            {
                holder += " Borrower: " + Borrower;
            }
            return holder;
        }

        public bool IsBorrowed()
        {
            if (borrower != "")
            {
                return true;
            }
            else return false;
        }
        public bool Borrow(string borrower)
        {
            if (!IsBorrowed())
            {
                this.borrower = borrower;
                return true;
            }
            else return false;
        }
        public void Receive()
        {
            if (IsBorrowed())
            {
                borrower = "";
                borrowers++;
            }
        }
    }
}
