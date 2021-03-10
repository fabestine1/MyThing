using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int PCS1, PCS2, PCS3, PCS4;
            int total;

            Console.Write("Please, enter the EC's for PCS1: ");
            PCS1 = int.Parse(Console.ReadLine());

            Console.Write("Please, enter the EC's for PCS2: ");
            PCS2 = int.Parse(Console.ReadLine());

            Console.Write("Please, enter the EC's for PCS3: ");
            PCS3 = int.Parse(Console.ReadLine());

            Console.Write("Please, enter the EC's for PCS4: ");
            PCS4 = int.Parse(Console.ReadLine());
            
                if(PCS1 != 0 && PCS1 != 3 || PCS2 != 0 && PCS2 != 3 || PCS3 != 0 && PCS3 != 3 || PCS4 != 0 && PCS4 != 3)
                {
                    Console.WriteLine("Wrong value."); 
                }
                    else
                    {
                        total = PCS1 + PCS2 + PCS3 + PCS4;

                        Console.WriteLine("Based on the earned EC's for PCS1 <" + PCS1 +
                            ">, PCS2 <" + PCS2 + ">, PCS3 <" + PCS3 + ">, PCS4 <" + PCS4 + ">,"
                            );
                        Console.WriteLine("the total earned EC's for PCS is " + total);
                    }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
