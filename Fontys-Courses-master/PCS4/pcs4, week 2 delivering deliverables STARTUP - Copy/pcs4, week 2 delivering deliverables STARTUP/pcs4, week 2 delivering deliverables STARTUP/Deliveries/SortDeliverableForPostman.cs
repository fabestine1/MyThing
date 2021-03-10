using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class SortDeliverableForPostman : IComparer<Deliverable>
    {
        public int Compare(Deliverable a, Deliverable b)
        {
            //List<Deliverable> odd = new List<Deliverable>();
            //List<Deliverable> even = new List<Deliverable>();




            if (a.Buyer.Street == b.Buyer.Street)
            {
                //if (a.Buyer.Housenumber % 2 == 1 && b.Buyer.Housenumber % 2 == 0)
                //{
                //    return 1;
                //}
                //else if (a.Buyer.Housenumber % 2 == 0 && b.Buyer.Housenumber % 2 == 1)
                //{
                //    return -1;
                //}
                //else if (a.Buyer.Housenumber % 2 == 1 && b.Buyer.Housenumber % 2 == 1)
                //{
                //    return a.Buyer.Housenumber.CompareTo(b.Buyer.Housenumber);
                //}
                //else return b.Buyer.Housenumber.CompareTo(a.Buyer.Housenumber);

                if (a.Buyer.Housenumber % 2 == 1)
                {
                    if (b.Buyer.Housenumber % 2 == 1)
                    {
                        return a.Buyer.Housenumber.CompareTo(b.Buyer.Housenumber);
                    }
                }
                else
                {
                    if (a.Buyer.Housenumber % 2 == 0)
                    {
                        if (b.Buyer.Housenumber % 2 == 1)
                        {
                            return -1;
                        }
                        else
                        {
                            b.Buyer.Housenumber.CompareTo(a.Buyer.Housenumber);
                        }
                    }
                }




                //return a.Buyer.Housenumber.CompareTo(b.Buyer.Housenumber);
                //    if(a.Buyer.Housenumber % 2 == 1)
                //    {
                //        odd.Add(a);
                //    }
                //    else
                //    {
                //        even.Add(a);
                //    }
                //    if (b.Buyer.Housenumber % 2 == 1)
                //    {
                //        odd.Add(b);
                //    }
                //    else
                //    {
                //        even.Add(b);
                //    }
                //}
                //odd.Sort();
                //even.Sort();
                //even.Reverse();







                //if (a.Buyer.Street == b.Buyer.Street)
                //{
                //    if (a.Buyer.Housenumber % 2 == 1 && b.Buyer.Housenumber % 2 == 0)
                //    {
                //        return -1;
                //    }
                //    else if (a.Buyer.Housenumber % 2 == 0 && b.Buyer.Housenumber % 2 == 0)
                //    {
                //        return b.Buyer.Housenumber.CompareTo(a.Buyer.Housenumber);
                //    }
                //    else
                //        return a.Buyer.Housenumber.CompareTo(b.Buyer.Housenumber);
                //    //return a.Buyer.Housenumber.CompareTo(b.Buyer.Housenumber);
                //}
                //else return 0;
            }
            return 0;
        }
    }
}