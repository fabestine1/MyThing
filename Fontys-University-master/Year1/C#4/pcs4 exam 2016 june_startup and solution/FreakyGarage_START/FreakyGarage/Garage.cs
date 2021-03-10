using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    public class Garage
    {
        private string name;        // the name of this garage
        private List<Car> myCars;   // the list of cars that are for sale in this garage


        public delegate void InterestHandler(Garage g, Car c, String reason);

        public event InterestHandler Bob;
        public event InterestHandler Fritz;

        public string Name { get { return name; } }

        public Garage(string name)
        {
            this.name = name;
            myCars = new List<Car>();
        }

        public void sortByYear()
        {
            // to do: assignment 1a
            this.myCars.Sort();
        }

        public void sortByBrandTypeAndPrice()
        {
            // to do: assignment 1b
            this.myCars.Sort(new Comparison<Car>(compareByBrandTypeAndPrice));
        }

        public int compareByBrandTypeAndPrice(Car first, Car second)
        {
            if (first.Brand.CompareTo(second.Brand) == 0)
            {
                if (first.Type.CompareTo(second.Type) == 0)
                {
                    return second.CurrentPrice.CompareTo(first.CurrentPrice);
                }
                else
                {
                    return first.Type.CompareTo(second.Type);
                }
            }
            else
            {
                return first.Brand.CompareTo(second.Brand);
            }
        }

        public List<Car> getAllCars()
        {
            return this.myCars;
        }

        public void addCar(Car c)
        {
            this.myCars.Add(c);
            // Notify interested listeners of a newly added car
            this.NotifyListeners(c, "New car added for sale");
        }

        public void NotifyListeners(Car c, String reason)
        {
            // To do: assignment 2
            if (c.CurrentPrice < 5000)
            {
                if (Bob != null)
                    Bob(this, c, reason);
            }

            if (c.Type == "Ferrari")
            {
                if (Fritz != null)
                    Fritz(this, c, reason);
            }
        }

        public int getMaxPriceFerrari(int n)
        {
            // To do: assignment 4
            //return -1; // Something silly to satisfy the compiler, to be changed by you
            if (n == 1)
            {
                return this.myCars[0].CurrentPrice;
            }
            else
            {
                if (myCars[n - 1].Brand.Equals("Ferrari"))
                {
                    int price = getMaxPriceFerrari(n - 1);
                    if (price > this.myCars[n - 1].CurrentPrice)
                    {
                        return this.myCars[n - 1].CurrentPrice;
                    }
                    else
                    {
                        return price;
                    }
                }
                else
                {
                    return getMaxPriceFerrari(n - 1);
                }
            }
        }
    }
}
