using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class SortParticipantsByAgeThenHobby : IComparer<Participant>
    {
        public int Compare(Participant a, Participant b)
        {
            int ageDifference = b.Age - a.Age;
            if (ageDifference == 0) return a.Hobby.CompareTo(b.Hobby);
            else return ageDifference;
        }
    }
}
