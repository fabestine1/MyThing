using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Interfaces;

namespace Telephony
{
    class SmartPhone : ISmartphone
    {
        public void Browse(string url)
        {
            //url.Any(char.IsDigit)
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
