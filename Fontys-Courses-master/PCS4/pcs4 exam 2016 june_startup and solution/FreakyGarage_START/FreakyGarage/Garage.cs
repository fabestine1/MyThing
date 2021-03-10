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

        public string Name { get { return name; } }

        public Garage(string name)
        {
            this.name = name;
            myCars = new List<Car>();
        }

        public void sortByYear()
        {
            // to do: assignment 1a
        }

        public void sortByBrandTypeAndPrice()
        {
            // to do: assignment 1b
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
        }

        public int getMaxPriceFerrari(int n)
        {
            // To do: assignment 4
            return -1; // Something silly to satisfy the compiler, to be changed by you
        }
    }
}
