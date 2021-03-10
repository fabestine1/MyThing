using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            int nr = 0;
            for(int i=0; i < 10; i++)
            {
                nr = i * 10;
                ints.Add(nr);
            }
            ints.Sort();
            foreach (int increment in ints)
            {
                Console.Write(increment + "-");
            }
            Console.WriteLine();
            ints.Reverse();
            foreach (int increment in ints)
            {
                Console.Write(increment + "-");
            }
            Console.WriteLine();
            ints.Reverse();
            foreach (int increment in ints)
            {
                Console.Write(increment + "-");
            }
            Console.WriteLine();
            ints.Clear();
            foreach (int increment in ints)
            {
                Console.Write(increment + "-");
            }
            Console.ReadKey();
        }
    }
}
