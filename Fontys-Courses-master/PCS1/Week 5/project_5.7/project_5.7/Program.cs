using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of sold products for agent nr 1: ");
            int nr1sold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of sold products for agent nr 2: ");
            int nr2sold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of sold products for agent nr 3: ");
            int nr3sold = Convert.ToInt32(Console.ReadLine());
            if (nr1sold > nr2sold && nr1sold > nr3sold)
            {
                Console.WriteLine("Loser sold {0} products!", nr3sold);
                Console.WriteLine("Winner sold {0} products!", nr1sold);
            }
            else if (nr2sold > nr1sold && nr2sold > nr3sold)
            {
                Console.WriteLine("Loser sold {0} products!", nr3sold);
                Console.WriteLine("Winner sold {0} products!", nr2sold);
            }
            else
            {
                Console.WriteLine("Loser sold {0} products!", nr1sold);
                Console.WriteLine("Winner sold {0} products!", nr2sold);
            }
            Console.ReadKey();
        }
    }
}
