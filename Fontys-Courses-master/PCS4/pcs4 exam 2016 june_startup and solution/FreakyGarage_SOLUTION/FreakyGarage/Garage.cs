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

        // delegate and events for assignment 2
        public delegate void InterestingCarHandler(Garage g, Car c, String reason);
        public event InterestingCarHandler processCheapCar;
        public event InterestingCarHandler processFerrari;

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

        // For assignment 1b, sorting
        public int compareByBrandTypeAndPrice(Car first, Car second)
        {
            int brandDifference = first.Brand.CompareTo(second.Brand);
            if (brandDifference == 0)
            {
                int typeDifference = first.Type.CompareTo(second.Type);
                if (typeDifference == 0)
                {
                    // Brand and type are the same, so sort on price in descending order
                    return second.CurrentPrice.CompareTo(first.CurrentPrice);
                }
                else
                    return typeDifference; // Brand is the same, sort on type
            }
            else
                return brandDifference; // Sort on brand
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
            if (c.Brand.Equals("Ferrari"))
                if (processFerrari != null)
                    processFerrari(this, c, reason);
            if (c.CurrentPrice < 5000)
                if (processCheapCar != null)
                    processCheapCar(this, c, reason);
        }

        public int getMaxPriceFerrari(int n)
        {
            // to do: assignment 4
            if (n == 0)
                return -1;
            else
            {
                if (myCars[n - 1].Brand.Equals("Ferrari"))
                {
                    int maxPriceOfTheRest = getMaxPriceFerrari(n - 1);
                    if (myCars[n - 1].CurrentPrice > maxPriceOfTheRest)
                        return myCars[n - 1].CurrentPrice;
                    else
                        return maxPriceOfTheRest;
                }
                else
                    return getMaxPriceFerrari(n - 1);
            }
        }
    }
}
