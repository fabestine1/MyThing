using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 127; i++)
            {
                char ascii = (char)i;
                Console.Write("{0}", ascii);
                count++;
                if (count > 9)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
