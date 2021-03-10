using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    class CompareCarsByBrandTypeAndPrice : IComparer<Car>
    {
        public int Compare(Car a, Car b)
        {
            int brand = a.Brand.CompareTo(b.Brand);
            if (brand != 0)
            {
                return brand;
            }
            else
            {
                int type = a.Type.CompareTo(b.Type);
                if(type!= 0)
                {
                    return type;
                }
                else
                {
                    return b.CurrentPrice - a.CurrentPrice;
                }
            }
        }
    }
}
