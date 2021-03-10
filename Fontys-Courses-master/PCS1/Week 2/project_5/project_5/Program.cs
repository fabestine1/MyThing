using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the annual interest rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of monthly payments: ");
            double numberMonthlyPayments = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nLoan amount:                 $  {0}", loanAmount);
            Console.WriteLine("Monthly Interest Rate:           {0}", interestRate/12/100);
            Console.WriteLine("Number of monthly payments:      {0}", numberMonthlyPayments);
            double monthlyPayment = ((interestRate / 12 / 100 * Math.Pow(1 + interestRate / 12 / 100, numberMonthlyPayments)) / (Math.Pow(1 + interestRate / 12 / 100, numberMonthlyPayments) - 1)) * loanAmount;
            Console.WriteLine("Monthly payment:             $   {0:0.000}", monthlyPayment);
            Console.WriteLine("Amount paid back:            $   {0:0.0}", monthlyPayment * numberMonthlyPayments);
            Console.WriteLine("Interest paid:               $   {0:0.00}", monthlyPayment * numberMonthlyPayments - loanAmount);
            Console.ReadKey();
        }
    }
}
