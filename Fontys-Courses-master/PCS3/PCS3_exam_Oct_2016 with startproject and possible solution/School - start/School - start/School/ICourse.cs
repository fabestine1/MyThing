using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface ICourse
    {
        void AddParticipant(int id, string name);
        int GetPricePerParticipant();
    }
}
