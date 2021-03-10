using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._1
{
    public enum Section
    {
        FirstClassSection,
        EconomySection
    }

    class Reservation
    {
        private bool[] reserved = new bool[10];
        private int[] count = new int[2];
        private int[] seat = new int[] { 1, 6 };

        public bool Assign(Section choice)
        {
            if (count[(int)choice] < 5)
            {
                reserved[seat[(int)choice] - 1] = true;
                seat[(int)choice]++;
                count[(int)choice]++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
