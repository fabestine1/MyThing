using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Exam_Start
{
	class Book
	{
        private static int number = 0;
        Random rnd = new Random();

        private double price;
        private int copies;

        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Genres Genre;

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0.01)
                {
                    price = value;
                }
            }
        }
        public int Copies
        {
            get { return copies; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    copies = value;
                }
            }
        }
        public Book(string nwTitle, string nwAuthor, Genres nwGenre, double nwPrice, int nwCopies)
        {
            number++;
            int id = number;
            Title = nwTitle;
            Author = nwAuthor;
            Genre = nwGenre;
            Price = nwPrice;
            Copies = nwCopies;
            Id = id;
        }
        public string AsString()
        {
            return "ID: " + Id + ", Title: " + Title + ", Genre: " + Genre + ", Price: " + Price + ", Copies: " + Copies;
        }
	}
}