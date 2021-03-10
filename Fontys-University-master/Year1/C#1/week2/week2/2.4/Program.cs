using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double loan, annualRate, monthlyRate, payment, paidBack, interest, temp;
            int monthlyPayments;

            Console.Write("Enter the Annual Interest Rate: ");
            annualRate = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the Number of Monthly Payments: ");
            monthlyPayments = int.Parse(Console.ReadLine());

            Console.Write("Enter the Loan Amount: ");
            loan = double.Parse(Console.ReadLine());

            monthlyRate = annualRate / 1200;

            temp = Math.Pow(1 + monthlyRate, monthlyPayments);

            payment = ((monthlyRate * temp) / (temp - 1)) * loan;

            paidBack = payment * monthlyPayments;

            interest = paidBack - loan; 

            Console.WriteLine("Loan Amount:              $" + loan);
            Console.WriteLine("Monthly Interest Rate:     " + monthlyRate);
            Console.WriteLine("Number of Montly payments: " + monthlyPayments);
            Console.WriteLine("Montly Payment:           $" + payment.ToString("#.###"));
            Console.WriteLine("Amount paid back:         $" + paidBack.ToString("#.#"));
            Console.WriteLine("Interest paid:            $" + interest.ToString("#.##"));

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
