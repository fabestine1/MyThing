using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Order
    {
        private int noOfChildren;
        private int noOfAdults;
        private int noOfSeniors;
        private static int nextFreeOrderNumber = 100;
        public int OrderNumber
        {
            get; private set;
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set
            {
                if (value >= 0)
                {
                    noOfChildren = value;
                }
                else
                {
                    noOfChildren = 0;
                }
            }
        }
        public int NoOfAdults
        {
            get { return noOfAdults; }
            set
            {
                if (value >= 0)
                {
                    noOfAdults = value;
                }
                else
                {
                    noOfAdults = 0;
                }
            }
        }
        public int NoOfSeniors
        {
            get { return noOfSeniors; }
            set
            {
                if (value >= 0)
                {
                    noOfSeniors = value;
                }
                else
                {
                    noOfSeniors = 0;
                }
            }
        }
        public bool IsCheckedIn
        {
            get; set;
        }
        private bool includeGuide
        {
            get; set;
        }
        private bool includeLunch
        {
            get; set;
        }
        public Order(int nwNoOfChildren, int nwNoOfAdults, int nwNoOfSeniors, bool nwIncludeGuide, bool nwIncludeLunch)
        {
            NoOfChildren = nwNoOfChildren;
            NoOfAdults = nwNoOfAdults;
            NoOfSeniors = nwNoOfSeniors;
            includeGuide = nwIncludeGuide;
            includeLunch = nwIncludeLunch;
            OrderNumber = nextFreeOrderNumber;
            nextFreeOrderNumber++;
        }
        private int getTotalNrVisitors()
        {
            return noOfChildren + noOfAdults + noOfSeniors;
        }
        public OrderType GetOrderType()
        {
            if (getTotalNrVisitors() > 7)
            {
                return OrderType.GROUP;
            }
            else if (noOfAdults == 2 && noOfChildren >= 1)
            {
                return OrderType.FAMILY;
            }
                return OrderType.NORMAL;
        }
        public double GetPrice()
        {
            double price = noOfAdults * 10 + noOfSeniors * 6;
            if (includeGuide)
            {
                price += 22.5;
            }
            if (includeLunch)
            {
                price += getTotalNrVisitors() * 6;
            }
            if (GetOrderType() == OrderType.FAMILY)
            {
                price -= 0.1 * price;
            }
            else if (GetOrderType() == OrderType.GROUP)
            {
                price -= 0.2 * price;
            }
            return price;
        }
        public string AsString()
        {
            string info = "Order nr.: " + OrderNumber + ", persons: " + getTotalNrVisitors() + ", price: " + GetPrice() + ", Status:  ";
            if (!IsCheckedIn)
            {
                info += "Not checked";
            }
            else
            {
                info += "Checked";
            }
            return info;
        }
        public string GetExtraInfo()
        {
            string extrainfo = AsString();
            if(includeGuide)
            {
                extrainfo += " Guide;";
            }
            if (includeLunch)
            {
                extrainfo += " Lunch;";
            }
            if (GetOrderType() == OrderType.FAMILY)
            {
                extrainfo += " Free Ice cream;";
            }
            else if (GetOrderType() == OrderType.GROUP)
            {
                extrainfo += " Free drink;";
            }
            return extrainfo;
        }
    }
}
