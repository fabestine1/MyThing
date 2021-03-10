using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public interface ITeacherRetirement
    {
        void WantToRetire(Teacher t, string reason);
    }
}
