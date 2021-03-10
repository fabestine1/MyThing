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


        public Song(string name, string artist, int year, double price)
        {
            this.Name = name;
            this.Artist = artist;
            this.Year = year;
            this.Price = price;
        }

        public void ChangePrice(double newPrice)
        {
            this.Price = newPrice;
        }

        public int CompareTo(Song other)
        {
            return  this.Year - other.Year;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.Artist + ", " + this.Year + " | €" + this.Price;
        }

    }
}
