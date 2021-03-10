using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class CompareByAgeAndHobby : IComparer<Participant>
    {
        public int Compare(Participant firstParticipant, Participant secondParticipant)
        {
            int ageCompare = secondParticipant.Age.CompareTo(firstParticipant.Age); //for descending
            if (ageCompare != 0)
            { return ageCompare; }
            else
            { return firstParticipant.Hobby.CompareTo(secondParticipant.Hobby); }
        }
    }
}
