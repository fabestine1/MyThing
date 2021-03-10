using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace service
{
    class Program
    {
        // Host the service within this EXE console application.
        static void Main()
        {
            // create a hosting process for CalculatorService
            ServiceHost host = new ServiceHost(typeof(CCalculator));

            // start hosting
            host.Open();

            // The service can now be accessed.
            Console.WriteLine("The service is being hosted");
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();

            // stop hosting
            host.Close();
        }
    }
}
