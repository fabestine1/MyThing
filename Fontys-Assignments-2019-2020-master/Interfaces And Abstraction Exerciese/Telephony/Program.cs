using System;
using System.Linq;
using Telephony.Interfaces;

namespace Telephony
{
    class Program
    {
        static void Main()
        {
            var phones = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            ISmartphone smartPhone = new SmartPhone();
            IPhone stationary = new StationaryPhone();

            foreach (var p in phones)
            {
                if (p.Length == 7)
                {
                    stationary.Call(p);
                }
                else if (p.Length == 10)
                {
                    smartPhone.Call(p);
                }
                else if (p.Any(char.IsLetter))
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var u in urls)
            {
                if (u.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartPhone.Browse(u);
                }
            }
        }
    }
}
