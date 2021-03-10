using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrsold = 1;
            int i = 1;
            int Min = 0;
            int Max = 0;
            while (nrsold >= 0)
            {
                Console.Write("Enter the amount of sold products for agent nr {0}: ", i);
                nrsold = Convert.ToInt32(Console.ReadLine());
                if (nrsold > Max)
                {
                    Max = nrsold;
                }
                if (nrsold < Min && nrsold >= 0 || i == 1)
                {
                    Min = nrsold;
                }
                i++;
            }
                Console.WriteLine("Loser sold {0} products!", Min);
                Console.WriteLine("Winner sold {0} products!", Max);
            Console.ReadKey();
        }
    }
}
