namespace ExamApril2018StartUp
{
    using System;

    public class NotABorrowableException : Exception
    {
        public NotABorrowableException(): base()
        {
        }
        public NotABorrowableException(String message): base(message)
        {
        }
    }
}
