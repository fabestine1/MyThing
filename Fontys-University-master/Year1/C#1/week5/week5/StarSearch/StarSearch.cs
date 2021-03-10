
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSearch
{
    class StarSearch
    {
        static void Main(string[] args)
        {
            Person Myass = new Person();
            int temp;

            for(int i = 1; i <= 2000; i++)
            {
                Console.Write("Enter the score of judge {0}: ", i);

                temp = int.Parse(Console.ReadLine());

                if(temp < 0 || temp > 10)
                {
                    i = 2000;
                }
                else
                {
                    Myass.AddJudge(temp);
                }
            }

            Console.WriteLine(Myass.Min);
            Console.WriteLine(Myass.Max);
            Console.WriteLine(Myass.Score);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
