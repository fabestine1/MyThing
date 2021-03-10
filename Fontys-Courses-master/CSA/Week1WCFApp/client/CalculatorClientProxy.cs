using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using CalculatorContract;

namespace client
{
    class CalculatorClientProxy : ClientBase<ICalculator>
    {
        public CalculatorClientProxy(Binding binding, EndpointAddress endpointAddress)
            : base(binding, endpointAddress)
        { }

        // Return the reference to the Service.
        public ICalculator GetCalculatorService()
        {
            return base.Channel;
        }
    }
}
