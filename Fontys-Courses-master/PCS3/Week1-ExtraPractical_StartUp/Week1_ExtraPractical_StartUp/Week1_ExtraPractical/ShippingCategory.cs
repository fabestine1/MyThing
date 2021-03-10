using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ExtraPractical
{
    class ShippingCategory
    {
        private string categoryName;
        private decimal pricePerKm;
        private double minimumWeight;
        private double maximumWeight;
        private int maxNumberOfPackages;
        private int totalNumberPackages;
        private int totalDistanceMeters;

        public string CategoryName
        {
            get { return categoryName; }
        }
        public double MinimumWeight
        {
            get { return minimumWeight; }
        }
        public double MaximumWeight
        {
            get { return maximumWeight; }
        }
        public int MaxNumberOfPackages
        {
            get { return maxNumberOfPackages; }
        }
        public int TotalNumberPackages
        {
            get { return totalNumberPackages; }
        }
        public int TotalDistanceMeters
        {
            get { return totalDistanceMeters; }
        }
        public void InitShippingCategory (string name, decimal priceKm, double minWeight, double maxWeight, int maxPackages)
        {
            categoryName = name;
            pricePerKm = priceKm;
            minimumWeight = minWeight;
            maximumWeight = maxWeight;
            maxNumberOfPackages = maxPackages;
        }
        public bool AddPackages (int distanceMeters)
        {
            if (totalNumberPackages + 1 <= maxNumberOfPackages)
            {
                totalNumberPackages++;
                totalDistanceMeters += distanceMeters;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetInfo()
        {
            return CategoryName + "\n- Total number of packages: " + TotalNumberPackages + "\n- Total distance in KM: " + Convert.ToDecimal(TotalDistanceMeters) / 1000 + "\n- Total price: " + Convert.ToDecimal(TotalDistanceMeters) / 1000 * pricePerKm;
        }
    }
}
