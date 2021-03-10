using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("\nYour BMI is: {0}", bmi);
            Console.WriteLine("\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9\nOverweight: between 25 and 29.9\nObese: 30 or greater");
            if(bmi >= 30)
            {
                Console.WriteLine("\nYour BMI is extremely high. Please contact your doctor because your health is in danger!");
            }
            Console.ReadKey();
        }
    }
}
