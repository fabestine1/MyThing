using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Interfaces
{
    interface ISmartphone : IPhone
    {
        public void Browse(string url);
    }
}
