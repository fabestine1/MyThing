using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int euros, eurocents, twos = 0, ones = 0, fiftycents = 0, twentycents = 0, tencents = 0, fivecents = 0, twocents = 0, onecent = 0;

            Console.Write("Enter euros: ");
            euros = int.Parse(Console.ReadLine());

            Console.Write("Enter eurocents: ");
            eurocents = int.Parse(Console.ReadLine());

            while(eurocents >= 100)
            {
                eurocents -= 100;
                euros ++; 
            }

            if(euros % 2 == 0)
            {
                twos = euros / 2;
            }
                else
                {
                    twos = euros / 2;
                    ones = 1;
                }

            if(eurocents >= 50)
            {
                eurocents -= 50;
                fiftycents++;
            }
                if(eurocents >= 20)
                {
                    eurocents -= 20;
                    twentycents++;
                }
                    if (eurocents >= 20)
                    {
                        eurocents -= 20;
                        twentycents++;
                    }
                        if (eurocents >= 10)
                        {
                            eurocents -= 10;
                            tencents++;
                        }
                            if (eurocents >= 5)
                            {
                                eurocents -= 5;
                                fivecents++;
                            }
                                if (eurocents >= 2)
                                {
                                    eurocents -= 2;
                                    twocents++;
                                }
                                    if (eurocents >= 2)
                                    {
                                        eurocents -= 2;
                                        twocents++;
                                    }
                                        if(eurocents == 1)
                                        {
                                            eurocents -= 1;
                                            onecent++;
                                        }

            Console.WriteLine("Minimizing the coins: ");
            Console.WriteLine("2 euro coins:     {0}", twos);
            Console.WriteLine("1 euro coins:     {0}", ones);
            Console.WriteLine("50 cents coins:   {0}", fiftycents);
            Console.WriteLine("20 cents coins:   {0}", twentycents);
            Console.WriteLine("10 cents coins:   {0}", tencents);
            Console.WriteLine("5 cents coins:    {0}", fivecents);
            Console.WriteLine("2 cents coins:    {0}", twocents);
            Console.WriteLine("1 cent coins:     {0}", onecent);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
