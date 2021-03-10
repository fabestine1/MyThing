using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    // Assignment 2a: (see also class Course)
    interface ICourse
    {
        void AddParticipant(int id, String name);
        int GetPricePerParticipant();
    }
}
