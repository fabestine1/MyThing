using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Exam_Solution
{
	class Book
	{
		private double price;
		private int copies;
		private Genres genre;
		private static int id;
		public int Id { get; private set; }
		public Genres Genre { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }

		public int Copies
		{
			get
			{
				return copies;
			}
			set
			{
				if (value < 0)
				{
					copies = 0;
				}
				else if (value > 50)
				{
					copies = 50;
				}
				else
				{
					copies = value;
				}
			}
		}
		public double Price
		{
			get
			{
				return price;
			}
			set
			{
				if (value < 0.01)
				{
					price = 0.01;
				}
				else
				{
					price = value;
				}
			}
		}
		public Book(string title, string author, Genres genre, double price, int copies)
		{
			Title = title;
			Author = author;
			Price = price;
			Copies = copies;
			Genre = genre;
			Id = ++id;
		}
		public string AsString()
		{
			return "ID: " + Id + ", Title: " + Title + ", Author: " + Author + ", Genre: " + Genre.ToString() + ", Price: " + Price + ", Copies: " + Copies;
		}
	}
}