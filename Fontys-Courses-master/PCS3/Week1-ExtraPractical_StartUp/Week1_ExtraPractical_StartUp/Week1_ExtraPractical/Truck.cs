using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ExtraPractical
{
    class Truck
    {
        private string licensePlate;
        private ShippingCategory letter;
        private ShippingCategory smallBox;
        private ShippingCategory mediumBox;
        private ShippingCategory largeBox;

        public string LicensePlate
        {
            get { return licensePlate; }
        }
        public ShippingCategory Letter
        {
            get { return letter; }
        }
        public ShippingCategory SmallBox
        {
            get { return smallBox; }
        }
        public ShippingCategory MediumBox
        {
            get { return mediumBox; }
        }
        public ShippingCategory LargeBox
        {
            get { return largeBox; }
        }
        public void InitTruck(string plate)
        {
            licensePlate = plate;
            letter = new ShippingCategory();
            letter.InitShippingCategory("Letter", 2.89m, 0, 1, 200);
            smallBox = new ShippingCategory();
            smallBox.InitShippingCategory("Small box", 4.50m, 1, 5, 60);
            mediumBox = new ShippingCategory();
            mediumBox.InitShippingCategory("Medium box", 9.98m, 5, 10, 30);
            largeBox = new ShippingCategory();
            largeBox.InitShippingCategory("Large box", 18.49m, 10, 20, 10);
        }
        public bool AddPackages(int distanceMeters, double weight)
        {
            if (weight >= 0 && weight <= 1)
            {
                return letter.AddPackages(distanceMeters);
            }
            if (weight >= 1 && weight <= 5)
            {
                return smallBox.AddPackages(distanceMeters);
            }
            if (weight >= 5 && weight <= 10)
            {
                return mediumBox.AddPackages(distanceMeters);
            }
            if (weight >= 10 && weight <= 20)
            {
                return largeBox.AddPackages(distanceMeters);
            }
            else
            {
                return false;
            }
        }
        public string GetInfo()
        {
            return "Truck with license plate: " + LicensePlate + "\n" + letter.GetInfo() + "\n" + smallBox.GetInfo() + "\n" + mediumBox.GetInfo() + "\n" + largeBox.GetInfo();
        }
    }
}
