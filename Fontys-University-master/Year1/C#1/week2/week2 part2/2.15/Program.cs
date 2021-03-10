using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            

            Console.Write("Enter the amount of numbers that you want: ");
            n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int negativebr = 0, positivebr = 0, zerobr = 0;
            
            

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Value {0}: ", (i + 1));
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            for(int j = 0; j < n; j++)
            {
                if(numbers[j] > 0)
                {
                    positivebr ++;
                }

                if(numbers[j] < 0)
                {
                    negativebr ++;
                }

                if(numbers[j] == 0)
                {
                    zerobr ++;
                }
            }

            if (positivebr == 0 || positivebr == 1)
            {
                
                Console.WriteLine("The positive value is {0}", positivebr);

            }
                else
                {
                    
                    Console.WriteLine("The positive values are {0}", positivebr);

                }

            if (negativebr == 0 || negativebr == 1)
            {

                Console.WriteLine("The negative value is {0}", negativebr);

            }
                else
                {
                
                    Console.WriteLine("The negative values are {0}", negativebr);

                }

            if (zerobr == 0 || zerobr == 1)
            {

                Console.WriteLine("The zero value is {0}", zerobr);

            }
                else
                {

                    Console.WriteLine("The zero values are {0}", zerobr);

                }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
