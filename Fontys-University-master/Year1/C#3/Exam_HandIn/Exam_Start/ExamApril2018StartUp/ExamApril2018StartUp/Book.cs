namespace ExamApril2018StartUp
{
    using System;

    public class Book : Readable, IBorrowable
    {
        private string author; 
        private string currentBorrower; 
        private int numberOfPreviousBorrowers;

        public string CurrentBorrower { get => currentBorrower; set => currentBorrower = value; }
        public int NumberOfPreviousBorrowers { get => numberOfPreviousBorrowers; set => numberOfPreviousBorrowers = value; }
        public string Author { get => author; set => author = value; }

        public Book(int id, string title, string author) 
            : base(id, title)
        {
            this.Author = author;
        }

        public bool Borrow(string borrower)
        {
            if (CurrentBorrower == String.Empty || CurrentBorrower == null)
            {
                this.CurrentBorrower = borrower;
                return false;
            }
            return true;
        }

        public void Receive()
        {
            if (CurrentBorrower != String.Empty || CurrentBorrower != null)
            {
                this.CurrentBorrower = String.Empty;
                this.NumberOfPreviousBorrowers += 1;
            }
        }

        public bool IsBorrowed()
        {
            if (CurrentBorrower == String.Empty || CurrentBorrower == null)
                return false;
            return true;
        }

        public override string ToString()
        {
            return "Book:" +  base.ToString() + " Author: " + this.Author + ".";
        }
    }
}
