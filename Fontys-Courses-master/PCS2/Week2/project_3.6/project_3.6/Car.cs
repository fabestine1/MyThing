using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._6
{
    class Car
    {
        private string brand;
        private string imageFilename;
        private int productionYear;
        private int latestMileage;
        private int latestTotalLiters;
        private int latestLitersTanked;
        private int latestLitersLeft;

        public string Brand
        {
            get { return brand; }
        }
        public string ImageFilename
        {
            get { return imageFilename; }
        }
        public int ProductionYear
        {
            get { return productionYear; }
        }
        public int LatestMileage
        {
            get { return latestMileage; }
        }
        public Car(string nwBrand, int nwMileage, int nwTotalLiters)
        {
            brand = nwBrand;
            latestMileage = nwMileage;
            latestTotalLiters = nwTotalLiters;
        }
        public void UpdateCar(int litersLeft, int litersRefueled, int mileage)
        {
            latestLitersLeft = litersLeft;
            latestLitersTanked = litersRefueled;
            latestMileage = mileage;
            latestTotalLiters += litersRefueled;
        }
        public double GetFuelEfficiency()
        {
            return (double) LatestMileage / (latestTotalLiters - latestLitersTanked - latestLitersLeft);
        }
        public string GetInfo()
        {
            return "Brand: " + Brand + "\nProduction year: " + ProductionYear + "\nTotal mileage: " + latestMileage + "\nTotal liters: " + latestTotalLiters + "\nLast tanked liters: " + latestLitersTanked + "\nLast left liters: " + latestLitersLeft;
        }
    }
}
