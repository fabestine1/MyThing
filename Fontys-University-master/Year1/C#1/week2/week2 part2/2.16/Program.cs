using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;

            Console.Write("Enter your weight: ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            height = double.Parse(Console.ReadLine());

            bmi = weight / Math.Pow(height, 2);

            if(bmi < 18.5)
            {
                Console.WriteLine("BMI = {0}, Underweight", bmi);        
            }
                else if(bmi >= 18.5 && bmi < 25)
                {
                    Console.WriteLine("BMI = {0}, Normal", bmi);
                }
                    else if(bmi >= 25 && bmi < 29)
                    {
                        Console.WriteLine("BMI = {0}, Overweight", bmi);
                    }
                        else
                        {
                            Console.WriteLine("BMI = {0}, Obese", bmi);

                            Console.WriteLine("Your BMI is extremely high.Please contact your doctor because your health is in danger!");
                        }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
