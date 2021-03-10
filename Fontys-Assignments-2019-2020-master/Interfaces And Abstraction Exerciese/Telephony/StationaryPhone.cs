using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Interfaces;

namespace Telephony
{
    class StationaryPhone : IPhone
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
