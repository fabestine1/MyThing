using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    class SortStartUpsByNrOfDonationsAndName : IComparer<StartUp>
    {
        public int Compare(StartUp a, StartUp b)
        {
            int nrDifference = b.getNrOfDonations().CompareTo(a.getNrOfDonations());
            if (nrDifference == 0) return a.Name.CompareTo(b.Name);
            return nrDifference;
        }
    }
}
