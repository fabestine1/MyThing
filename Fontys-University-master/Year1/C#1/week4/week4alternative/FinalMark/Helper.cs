using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMark
{
    class Helper
    {
        public int Br { get; set; }

        public int FinalMark(int firstMark, int secondMark)
        {
            int temp;
            Br++;
            if (firstMark > 50 && secondMark > 50)
            { 
                temp = (firstMark + secondMark) / 2;
            }
            else
            {
                temp = firstMark;
                if(temp > secondMark)
                {
                    temp = secondMark ;
                }
            }

            if (temp % 10 < 5)
            {
                return temp / 10;
            }
            else
            {
                return temp / 10 + 1;
            }
        }

        public decimal BTW(decimal price, String lowOrHigh)
        {
            decimal finalPrice = 0, low = 0.06M, high = 0.21M;

            if(lowOrHigh == "Low" || lowOrHigh == "low")
            {
                finalPrice = price - low * price;  
            }
            else if(lowOrHigh == "High" || lowOrHigh == "high")
            {
                finalPrice = price - high * price;
            }
            else
            {
                finalPrice = 0;
            }
            Br++;
            return finalPrice;
        }
        public int DaysInMonth(String month, int year)
        {
            int days;
            bool checker = false;
            if (month == "january" || month == "march" || month == "may" ||
                month == "july" || month == "august" || month == "october" || month == "december")
            {
                days = 31;
            }
            else if (month == "april" || month == "may" || month == "juny" || month == "september" || month == "november")
            {
                days = 30;
            }
            else if (month == "february")
            {
                for(int i = 2020; i > 0; i -= 4)
                {
                    if (year == i)
                    {
                        checker = true;
                    }
                }
                if(checker == true)
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            else
            {
                days = -1;
            }

            Br++;
            return days;
        }
        public int Counter()
        {
            return this.Br;
        }
    }
}
