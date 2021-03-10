using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Helper:IComparer<Drumble>
    {

       public int Compare(Drumble first, Drumble second)
        {
            if(first.NrOfCredits < second.NrOfCredits)
            {
                return -1;

            }
            else
            {
                if(first.NrOfCredits == second.NrOfCredits)
                { return 0;
                }
                else
                {
                    return +1;
                }
            }
        }
    }
}
