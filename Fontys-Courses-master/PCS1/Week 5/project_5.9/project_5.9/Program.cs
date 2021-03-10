using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrsold = 1;
            int i = 1;
            int Min = 0;
            int Max = 0;
            string agentname = "";
            string winnerName = "";
            string loserName = "";
            while (nrsold >= 0)
            {
                Console.Write("\nEnter the amount of sold products for agent nr {0}: ", i);
                nrsold = Convert.ToInt32(Console.ReadLine());
                if (nrsold >= 0)
                {
                    Console.Write("Enter the name of the agent nr {0}: ", i);
                    agentname = Console.ReadLine();
                }
                if (nrsold > Max)
                {
                    Max = nrsold;
                    winnerName = agentname;
                }
                if (nrsold < Min && nrsold >= 0 || i == 1)
                {
                    Min = nrsold;
                    loserName = agentname;
                }
                i++;
            }
            Console.WriteLine("Loser {0} sold {1} products!", loserName, Min);
            Console.WriteLine("Winner {0} sold {1} products!", winnerName, Max);
            Console.ReadKey();
        }
    }
}
