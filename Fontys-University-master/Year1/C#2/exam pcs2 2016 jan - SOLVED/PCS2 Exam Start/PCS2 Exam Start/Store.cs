namespace PCS2_Exam_Start
{
    using System.Collections.Generic;

    public class Store
	{
        private List<Book> bookCollection;
	    public string Name { get; set; }

	    private Book[] history;
	    int historyIndex = 0;

        public Store(string name)
	    {
	        this.bookCollection = new List<Book>();
	        Name = name;
	        history = new Book[10];
        }

	    public Book GetBook(string Title, string Author, string storage)
	    {
	        foreach (var book in this.bookCollection)
	        {
	            if (book.Title == Title && book.Author == Author)
	            {
	                return book;
	            }
	        }
	        return null;
	    }

	    public bool AddBook(string Title, string Author, Genre genre, decimal price, int copies)
	    {
	        foreach (var book in this.bookCollection)
	        {
	            if (book.Title != Title && book.Author != Author)
	            {
	                Book temp = new Book(Title, Author, genre, price, copies);
	                this.bookCollection.Add(book);
	                return true;
	            }
	        }
	        return false;
	    }

	    public string SellBook(string Title, string Author)
	    {
	        foreach (var book in this.bookCollection)
	        {
	            if (book.Copies > 0)
	            {
	                return "Successfully sold a book!";
	                book.Copies--;
	            }
	            else
	            {
	                return "This book is sold out!";
                }
	        }
	        return null;
	    }

	    public List<Book> GetListOfBooks()
	    {
	        return this.bookCollection;
	    }

	    public List<Book> GetListOfBooks(Genre genre)
	    {
            var tempList = new List<Book>();

	        if (genre == Genre.COMEDY)
	        {
	            foreach (var book in this.bookCollection)
	            {
	                if (book.Genre == genre)
	                {
	                    tempList.Add(book);

                    }
	            }
	        }
	        else if (genre == Genre.HORROR)
	        {
	            foreach (var book in this.bookCollection)
	            {
	                if (book.Genre == genre)
	                {
	                    tempList.Add(book);

	                }
	            }
            }

	        return tempList;

	    }

	    public string GetHistory()
	    {
	        if (history[0] != null)
	        {
	            string text = "";
	            int count = 0;
	            decimal sum = 0, min = history[0].Price, max = history[0].Price;
	            foreach (Book b in history)
	            {
	                if (b != null)
	                {
	                    count++;
	                    if (b.Price < min)
	                    {
	                        min = b.Price;
	                    }
	                    if (b.Price > max)
	                    {
	                        max = b.Price;
	                    }
	                    sum += b.Price;
	                    text += b.Title + "\n";
	                }
	            }
	            return "The " + count + " most recently sold books:\n" + text + "Statistics:\nAverage price: " + (sum / count) + "\nMinimum price: " + min + "\nMaximum price: " + max;
	        }
	        return "No books have been sold yet.";
	    }
    }
}
