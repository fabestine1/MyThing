using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorContract;

namespace service
{
    class Program
    {
        // Host the service within this EXE console application.
        static void Main()
        {
            // create a hosting process for CalculatorService
            ServiceHost host = new ServiceHost(typeof(CCalculator));

            // define an endpoint for the service
            Type contract = typeof(ICalculator);
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            host.AddServiceEndpoint(contract, binding, address);

            // start hosting
            host.Open();

            // The service can now be accessed.
            Console.WriteLine("The service is being hosted at address " + address);
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();

            // stop hosting
            host.Close();
        }
    }
}
