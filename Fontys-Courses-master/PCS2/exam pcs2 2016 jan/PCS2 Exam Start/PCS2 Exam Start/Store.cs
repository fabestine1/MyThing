using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Exam_Start
{
    class Store
    {
        private List<Book> storage;
        public Book[] history;
        private int lastIndex = 0;
        public string Name { get; set; }
        public Store(string nwName)
        {
            Name = nwName;
            storage = new List<Book>();
            history = new Book[10];
        }
        public Book GetBook(string title, string author)
        {
            foreach (Book book in storage)
            {
                if (title == book.Title && author == book.Author)
                {
                    return book;
                }
            }
            return null;
        }
        public bool AddBook(string title, string author, Genres genre, double price, int copies)
        {
            if(GetBook(title, author) != null)
            {
                return false;
            }
            else {
                Book book = new Book(title, author, genre, price, copies);
                storage.Add(book);
                return true;
            }
        }
        public string SellBook(string title, string author)
        {
            Book book = GetBook(title, author);
            if (book.Copies >= 1)
            {
                book.Copies--;
                history[lastIndex % 10] = book;
                lastIndex++;
                return "Successfully sold a book!";
            }
            else
            {
                return "This book is sold out!";
            }
        }
        public List<Book> GetListOfBooks()
        {
            return storage;
        }
        public List<Book> GetListOfBooks(Genres genre)
        {
            List<Book> books = new List<Book>();
            foreach(Book book in storage)
            {
                if(genre == book.Genre)
                {
                    books.Add(book);
                }
            }
            return books;
        }
        public string GetHistory()
        {
            string list = "";
            double sum = 0;
            double minimum = 0;
            double maximum = 0;
            double average = 0;
            if (lastIndex > 0)
            {
                foreach (Book book in history)
                {
                    if (book != null)
                    {
                        list += book.Title;
                        if (book.Price < minimum || minimum == 0)
                        {
                            minimum = book.Price;
                        }
                        if (book.Price > maximum)
                        {
                            maximum = book.Price;
                        }
                        sum += book.Price;
                    }
                }
                if(lastIndex > 10)
                { average = sum / 10; }
                else
                { average = sum / lastIndex; }
               
                return String.Format("The {0} most recently sold books: {1}\nStatistics: Average price: {2}\nMinimum price: {3}\nMaximum price: {4}", lastIndex % 10, list, average, minimum, maximum);
            }
            else
            {
                return "No books have been sold yet.";
            }
        }
    }
}
