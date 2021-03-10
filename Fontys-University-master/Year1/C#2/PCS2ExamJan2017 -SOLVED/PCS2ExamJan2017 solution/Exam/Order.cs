using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Order
    {
        // assignment 2a
        // VARIABLES
        private int noOfChildren;
        private int noOfAdults;
        private int noOfSeniors;
        private static int nextFreeOrderNumber=100;

        // PROPERTIES
        public int NoOfChildren
        {
            get { return this.noOfChildren; }
            set
            {
                if (value < 0)
                {
                    this.noOfChildren = 0;
                }
                else
                {
                    this.noOfChildren = value;
                }
            }
        }

        public int NoOfAdults
        {
            get { return this.noOfAdults; }
            set
            {
                if (value < 0)
                {
                    this.noOfAdults = 0;
                }
                else
                {
                    this.noOfAdults = value;
                }
            }
        }

        public int NoOfSeniors
        {
            get { return noOfSeniors; }
            set
            {
                if (value < 0)
                {
                    this.noOfSeniors = 0;
                }
                else
                {
                    this.noOfSeniors = value;
                }
            }
        }
        public int OrderNumber { get; private set; }
        public bool IsCheckedIn { get; set; }
        private bool includeGuide { get; set; }
        private bool includeLunch { get; set; }
 



        // CONSTRUCTORS
        // assignment 2b
        public Order(int nrOfChildren, int nrOfAdults, int nrOfSeniors, bool includeGuide, bool includeLunch)
        {
            this.NoOfChildren = nrOfChildren;
            this.NoOfAdults = nrOfAdults;
            this.NoOfSeniors = nrOfSeniors;
            this.includeGuide = includeGuide;
            this.includeLunch = includeLunch;
            this.OrderNumber = nextFreeOrderNumber;
            nextFreeOrderNumber++;
            this.IsCheckedIn = false;
        }

        // METHODS
        // assignment 2c
        public int GetTotalNrVisitors()
        {
            return this.noOfChildren + this.noOfAdults + this.NoOfSeniors;
        }

        // assignment 2d
        public OrderType GetOrderType()
        {
            if (this.GetTotalNrVisitors() >= 8)
            {
                return OrderType.GROUP;
            }
            else if (this.noOfAdults == 2 && this.noOfChildren > 1)
            {
                return OrderType.FAMILY;
            }
            return OrderType.NORMAL;
        }
        // assignment 2e
        public double GetPrice()
        {
            double price = 0;
            price = this.noOfAdults * 10 + this.noOfSeniors * 6;
            if (this.includeGuide) { price += 22.50; }
            if (this.includeLunch) { price += GetTotalNrVisitors() * 6; }

            if (this.GetOrderType() == OrderType.FAMILY)
            {
                price -= price*0.1;
            }
            if (this.GetOrderType() == OrderType.GROUP)
            {
                price -= price * 0.2;
            }
            return price;
        }
        // assignment 2f
        public string AsString()
        {
            string isChecked;
            if (this.IsCheckedIn)
            {
                isChecked = " Checked";
            }
            else
            {
                isChecked = " Not checked";
            }
            return "Order nr.: " + this.OrderNumber + ", persons: " + this.GetTotalNrVisitors() +
                ", price: " + this.GetPrice() + " Status: " + isChecked;
        }

        // assignment 2g
        public string GetExtraInfo()
        {
            string str = "";
            if (!this.includeGuide && !this.includeLunch)
            {
                str += "None.";
            }
            else
            {
                if (this.includeGuide)
                {
                    str += "Guide; ";
                }
                if (this.includeLunch)
                {
                    str += "Lunch; ";
                }
                if (this.GetOrderType()==OrderType.FAMILY)
                {
                    str += "Free Ice cream;";
                }
                if (this.GetOrderType() == OrderType.GROUP)
                {
                    str += "Free Drink;";
                }
            }
            return str;
        }
    }
}
