using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Calculate the total PCS ES's for an ICT student: PCS1 + PCS2 + PCS3 + PCS4.");
            Console.WriteLine("For each PCS course a student can earn either:");
            Console.WriteLine("             3 EC's <passed the exam> or");
            Console.WriteLine("             0 EC's <failed the exam>.");
            Console.Write("Please, enter the the EC's for PCS1: ");
            string pcs1 = Console.ReadLine();
            Console.Write("Please, enter the the EC's for PCS2: ");
            string pcs2 = Console.ReadLine();
            Console.Write("Please, enter the the EC's for PCS3: ");
            string pcs3 = Console.ReadLine();
            Console.Write("Please, enter the the EC's for PCS4: ");
            string pcs4 = Console.ReadLine();
            Console.WriteLine("Based on the earned EC's for PCS1 <{0}>, PCS2 <{1}>, PCS3 <{2}>, PCS4 <{3}>,", pcs1, pcs2, pcs3, pcs4);
            int sum = Convert.ToInt32(pcs1) + Convert.ToInt32(pcs2) + Convert.ToInt32(pcs3) + Convert.ToInt32(pcs4);
            Console.Write("the total earned ECs for PCS is " + sum + "!");
            Console.ReadKey();
        }
    }
}
