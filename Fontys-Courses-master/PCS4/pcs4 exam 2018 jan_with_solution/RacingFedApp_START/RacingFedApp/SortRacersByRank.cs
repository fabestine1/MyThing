using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingFedApp
{
    class SortRacersByRank : IComparer<Racer>
    {
        public int Compare(Racer a, Racer b)
        {
            return b.Rank - a.Rank;
        }
    }
}
