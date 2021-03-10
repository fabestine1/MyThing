using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string wcT = "Welcome to ";
            string fnt = "Fontys ";
            string ICTin = "ICT in ";
            string eind = "Eindhoven.";

            Console.WriteLine("Welcome to Fontys ICT in Eindhoven.");

            Console.Write("Welcome ");
            Console.Write("to ");
            Console.Write("Fontys ");
            Console.Write("ICT ");
            Console.Write("in ");
            Console.Write("Eindgoven.");

            Console.WriteLine();

            Console.WriteLine(wcT + fnt + ICTin + eind);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
