using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankApp
{
    class PiggyBankApp
    {
        static void Main(string[] args)
        {
            PiggyBank myPiggyBank = new PiggyBank("Laniasd");

            myPiggyBank.Add1TwoEuros();
            myPiggyBank.Add1OneEuros();

            myPiggyBank.AddMoney(10, 7);

            myPiggyBank.ChangeName("OWEJRQOWRO");

            Console.WriteLine(myPiggyBank.Info());

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
