using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._13
{
    class Truck
    {
        private string type;
        private ShippingCategory letter = new ShippingCategory("letter", 2.89m, 200, 0, 1);
        private ShippingCategory smallBox = new ShippingCategory("small box", 4.50m, 60, 1, 5);
        private ShippingCategory middleBox = new ShippingCategory("medium box", 9.98m, 30, 5, 10);
        private ShippingCategory largeBox = new ShippingCategory("large box", 18.49m, 10, 10, 20);
        private ShippingCategory container = new ShippingCategory("container", 36.87m, 3, 20, 600);

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public void AddPackage(int distance, double weight)
        {
            if (weight <= 1)
            {
                letter.AddPackage(distance, weight);
            }
            else if (weight >= 1 && weight <= 5)
            {
                smallBox.AddPackage(distance, weight);
            }
            else if (weight >= 5 && weight <= 10)
            {
                middleBox.AddPackage(distance, weight);
            }
            else if (weight >= 10 && weight <= 20)
            {
                largeBox.AddPackage(distance, weight);
            }
            else if (weight >= 20 && weight <= 600)
            {
                container.AddPackage(distance, weight);
            }
        }

        public string PrintAllInfo() {
            return "Info for truck type " + Type + ":\n" + letter.PrintInfo() + smallBox.PrintInfo() + middleBox.PrintInfo() + largeBox.PrintInfo() + container.PrintInfo();
        }
    }
}
