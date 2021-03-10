using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Exam_Solution
{
	class Store
	{
		private List<Book> storage;
		//Start Bonus
		private Book[] history;
		int historyIndex = 0;
		//End Bonus
		public string Name { get; private set; }
		public Store(string name)
		{
			Name = name;
			storage = new List<Book>();
			//Start Bonus
			history = new Book[10];
			//End Bonus
		}
		private Book GetBook(string title, string author)
		{
			for (int i = 0; i < storage.Count; i++)
			{
				if (storage[i].Title == title && storage[i].Author == author)
				{
					return storage[i];
				}
			}
			return null;
		}
		public bool AddBook(string title, string author, Genres genre, double price, int amount)
		{
			if (GetBook(title, author) == null)
			{
				storage.Add(new Book(title, author, genre, price, amount));
				return true;
			}
			return false;
		}
		public string SellBook(string title, string author)
		{
			string message = "";
			Book book = GetBook(title, author);
			if (book.Copies > 0)
			{
				book.Copies--;
				//Start Bonus
				history[historyIndex] = book;
				historyIndex = (historyIndex + 1) % 10;
				//End Bonus
				message = "Successfully sold a book!";
			}
			else
			{
				message = "This book is sold out!";
			}
			return message;
		}
		public List<Book> GetListOfBooks()
		{
			return storage;
		}
		public List<Book> GetListOfBooks(Genres genre)
		{
			List<Book> booksWithGenre = new List<Book>();
			foreach (Book b in storage)
			{
				if (b.Genre == genre)
				{
					booksWithGenre.Add(b);
				}
			}
			return booksWithGenre;
		}
		public string GetHistory()
		{
			if (history[0] != null)
			{
				string text = "";
				int count = 0;
				double sum = 0, min = history[0].Price, max = history[0].Price;
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