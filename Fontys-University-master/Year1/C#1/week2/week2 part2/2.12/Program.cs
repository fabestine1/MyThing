using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press any key: ");
            
            ConsoleKeyInfo key = Console.ReadKey();
            
            int code = (int)key.KeyChar;

            Console.WriteLine();
            Console.WriteLine("Integer representation of you key: {0}", code);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
