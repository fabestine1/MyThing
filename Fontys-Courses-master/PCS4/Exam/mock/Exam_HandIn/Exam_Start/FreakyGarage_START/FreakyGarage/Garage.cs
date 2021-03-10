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
        public delegate void NotifyHandler(Garage g, Car c, String reason);
        public event NotifyHandler Below5000Update;
        public event NotifyHandler FerrariUpdate;

        public string Name { get { return name; } }

        public Garage(string name)
        {
            this.name = name;
            myCars = new List<Car>();
        }

        public void sortByYear()
        {
            // to do: assignment 1a
            myCars.Sort();
        }

        public void sortByBrandTypeAndPrice()
        {
            // to do: assignment 1b
            myCars.Sort(new CompareCarsByBrandTypeAndPrice());
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
            if(c.CurrentPrice < 5000)
            {
                if (Below5000Update != null) Below5000Update(this, c, reason);
            }
            if (c.Brand == "Ferrari")
            {
                if (FerrariUpdate != null) FerrariUpdate(this, c, reason);
            }
        }

        public int getMaxPriceFerrari(int n)
        {
            // To do: assignment 4
            if (n == 0) return -1;
            if (myCars[n - 1].Brand == "Ferrari")
            {
                int maxPriceOfRest = getMaxPriceFerrari(n - 1);
                if (myCars[n - 1].CurrentPrice > maxPriceOfRest) return myCars[n - 1].CurrentPrice;
                return maxPriceOfRest;
            }
            return getMaxPriceFerrari(n - 1);
        }
    }
}
