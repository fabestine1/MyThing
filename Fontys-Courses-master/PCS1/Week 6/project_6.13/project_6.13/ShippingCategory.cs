using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._13
{
    class ShippingCategory
    {
        private string categoryName;
        private decimal pricePerKm;
        private int maxNumberPackages;
        private double minWeight;
        private double maxWeight;
        private int totalNumberPackages;
        private int totalDistance;
        private decimal totalPrice;
        private int minDistance;
        private int maxDistance;

        public string CategoryName
        {
            get { return categoryName; }
            private set { categoryName = value; }
        }

        public decimal PricePerKm
        {
            get { return pricePerKm; }
            private set { pricePerKm = value; }
        }

        public int MaxNumberPackages
        {
            get { return maxNumberPackages; }
            private set { maxNumberPackages = value; }
        }
        public double MinWeight
        {
            get { return minWeight; }
            private set { minWeight = value; }
        }
        public double MaxWeight
        {
            get { return maxWeight; }
            private set { maxWeight = value; }
        }
        public int TotalNumberPackages
        {
            get { return totalNumberPackages; }
            private set { totalNumberPackages = value; }
        }
        public int TotalDistance
        {
            get { return totalDistance; }
            private set { totalDistance = value; }
        }
        public decimal TotalPrice
        {
            get { return TotalDistance * PricePerKm; }
            private set { totalPrice = value; }
        }
        public int MinDistance
        {
            get { return minDistance; }
            private set { minDistance = value; }
        }
        public int MaxDistance
        {
            get { return maxDistance; }
            private set { maxDistance = value; }
        }

        public ShippingCategory(string categoryName, decimal pricePerKm, int maxNumberPackages, double minWeight, double maxWeight)
        {
            CategoryName = categoryName;
            PricePerKm = pricePerKm;
            MaxNumberPackages = maxNumberPackages;
            MinWeight = minWeight;
            MaxWeight = maxWeight;
        }
        public void AddPackage (int distance, double weight)
        {
            TotalNumberPackages++;
            TotalDistance += distance;
            if (distance < MinDistance || MinDistance == 0)
            {
                MinDistance = distance;
            }
            if (distance > MaxDistance)
            {
                MaxDistance = distance;
            }
        }
        public string PrintInfo()
        {
            if (TotalNumberPackages > 0)
            {
                return CategoryName + "\n\t---> total number of packages = " + TotalNumberPackages + "\n\t---> total price = " + TotalPrice + "\n\t---> total distance = " + TotalDistance + "\n\t---> minimal distance = " + MinDistance + "\n\t---> maximal distance = " + MaxDistance + "\n";
            }
            else
            {
                return CategoryName + "\n\t---> total number of packages = 0\n";
            }
            }
    }
}
