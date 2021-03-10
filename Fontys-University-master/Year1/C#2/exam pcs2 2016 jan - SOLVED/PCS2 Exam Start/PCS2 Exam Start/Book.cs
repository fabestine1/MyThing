namespace PCS2_Exam_Start
{
    public class Book
    {
        public readonly int CONSTANT_ID = 1;

        private decimal price;
        private int copies;

	    public int id { get; }
	    public string Title { get; set; }
	    public string Author { get; set; }
	    public Genre Genre { get; set; }

	    public decimal Price {
	        get { return this.price; }
	        set
	        {
	            if (value >= 0.01m)
	            {
	                value = this.price;
	            }
	        }
	    }

        public int Copies
        {
            get { return this.copies; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    value = this.copies;
                }
            }
        }

        public Book(string Title, string Author, Genre genre, decimal price, int copies)
        {
            this.id = CONSTANT_ID++;
            this.Title = Title;
            this.Author = Author;
            this.Genre = genre;
            this.Price = price;
            this.Copies = copies;
        }

        public string AsString()
        {
            return $"ID: {this.id}, Title: {this.Title}, Author: {this.Author}, Genre: {this.Genre}," +
                   $"Price: {this.Price}, Copies: {this.copies}";
        }
    }
}