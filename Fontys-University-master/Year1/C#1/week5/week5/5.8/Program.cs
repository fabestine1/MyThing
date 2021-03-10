using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[200];
            string[] people = new string[200];

            int n = 200, biggest = 0, smallest = 0;
            String bigName = "", smallName = "";
            
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter the amount of sold products for agent {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter the name of agent {0}: ", i + 1);
                people[i] = Console.ReadLine();

                if(numbers[i] < 0)
                {
                    n = i;
                }
            }

            biggest = numbers[0];
            bigName = people[0];
            smallest = numbers[0];
            smallName = people[0];

            for(int i = 0; i < n; i++)
            {
                if(biggest < numbers[i])
                {
                    biggest = numbers[i];
                    bigName = people[i];
                }
                if(smallest > numbers[i])
                {
                    smallest = numbers[i];
                    smallName = people[i];
                }
            }

            Console.WriteLine("Winner is {0} with {1} products sold", bigName, biggest);
            Console.WriteLine("Loser is {0} wtih {1} products sold", smallName, smallest);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
