using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    public class Car : IComparable<Car>
    {
        // fields
        private static int nextFreeIdNr;// keeps track of nr of car objects created
                                        // used to assign the next free id nr
        private int idnr;               // a unique id nr for a car
        private string brand;           // the brand of the car
        private string car_type;        // the type of the car
        private int year;               // the manufacturing year of the car
        private int current_price;      // the current price of the car

        // properties
        public string Brand { get { return this.brand;  } }
        public string Type { get { return this.car_type; } }
        public int Year { get { return this.year; } }
        public int CurrentPrice { get { return this.current_price; } }

        // constructor
        public Car(string brand, string car_type, int year, int price)
        {
            nextFreeIdNr++;
            this.idnr = nextFreeIdNr;
            this.brand = brand;
            this.car_type = car_type;
            this.year = year;
            this.current_price = price;
        }

        // methods
        public void setCurrentPrice(int price)
        {
            this.current_price = price;
        }

        public override string ToString()
        {
            string holder = this.idnr.ToString() + " : " + this.brand + " " + this.car_type +
                " year: " + this.year.ToString() +
                " current price: " + this.current_price.ToString(); 
            return holder;
        }
        public int CompareTo(Car c)
        {
            return c.year - this.year;
        }
    }
}
