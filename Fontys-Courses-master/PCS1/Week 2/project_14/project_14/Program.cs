using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 'A', 'B', 'C', 'a', 'b', 'c', '0', '1', '2', '$', '+', '/' };
            foreach (var item in array)
            {
                Console.WriteLine("Code for {0}: {1}", (char) item, item);
            }
            Console.Write("\nEnter a key followed by enter: ");
            int key = Convert.ToInt32(Console.Read());
            Console.WriteLine("Code for {0}: {1}", (char) key, key);
            Console.ReadKey();
        }
    }
}
