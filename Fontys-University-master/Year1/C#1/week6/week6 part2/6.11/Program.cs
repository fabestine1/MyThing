using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 31; i++)
            {
                for(int j = 0; i < 127; j++)
                Console.WriteLine((char)i);
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
