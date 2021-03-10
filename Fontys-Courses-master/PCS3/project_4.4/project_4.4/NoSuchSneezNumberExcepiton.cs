using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._4
{
    class NoSuchSneezNumberExcepiton : Exception
    {
        public NoSuchSneezNumberExcepiton() : base("There is no such sneeze number!")
        {

        }
    }
}
