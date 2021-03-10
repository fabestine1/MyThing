using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxStore
{
    public class Song : IComparable<Song>
    {
        public string Name { get; private set; }
        public string Artist { get; private set; } //Artist sometimes referred as band
        public int Year { get; private set; }
        public double Price { get; private set; }

        public delegate void ChangedPriceHandler(Song s, string reason);
        public event ChangedPriceHandler ChangedPrice;
        public delegate void ChangedPromoPriceHandler(Song s);
        public event ChangedPromoPriceHandler ChangedPromoPrice;

        public Song(string name, string artist, int year, double price)
        {
            this.Name = name;
            this.Artist = artist;
            this.Year = year;
            this.Price = price;
        }

        public void ChangePrice(double newPrice)
        {
            double oldPrice = Price;
            this.Price = newPrice;
            if(Artist == "The Beatles")
            {
                if (ChangedPrice != null) ChangedPrice(this, "a change of price");
            }
            if (oldPrice > 2 && Price <= 2)
            {
                if (ChangedPromoPrice != null) ChangedPromoPrice(this);
            }
        }

        public override string ToString()
        {
            return this.Name + ", " + this.Artist + ", " + this.Year + " | €" + this.Price;
        }
        public int CompareTo(Song s)
        {
            return Year.CompareTo(s.Year);
        }

    }
}
