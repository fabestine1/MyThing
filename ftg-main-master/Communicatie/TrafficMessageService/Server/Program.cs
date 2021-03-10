﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using MessageService;

namespace Garagemanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // creeer een host proces voor de TrafficMessageService
            ServiceHost host = new ServiceHost(typeof(CTrafficMessage));

            // creeer een zgn. end-point voor de service
            Type contract = typeof(ITrafficMessage);
            BasicHttpBinding binding = new BasicHttpBinding();
            string baseAddress = "http://localhost:8000/MEX";
            Uri address = new Uri(baseAddress + "/MessageService");
            host.AddServiceEndpoint(contract, binding, address);

            // creeer een zgn. mex endpoint om de wsdl van de service te hosten
            host.Description.Behaviors.Add(new ServiceMetadataBehavior());
            EndpointAddress endPointAddress = new EndpointAddress(baseAddress + "/MEX");
            ServiceEndpoint mexEndpoint = new ServiceMetadataEndpoint(endPointAddress);
            host.AddServiceEndpoint(mexEndpoint);

            // start de service
            host.Open();


            // hou het proces in de lucht tot de gebruiker op enter drukt
            Console.WriteLine("Service ITrafficMessage successfully hosted at address: ");
            Console.WriteLine("http://localhost:8000/MEX");
            Console.WriteLine("\nPress <enter> to end the server ...");

            Console.ReadLine();
        }
    }
}
