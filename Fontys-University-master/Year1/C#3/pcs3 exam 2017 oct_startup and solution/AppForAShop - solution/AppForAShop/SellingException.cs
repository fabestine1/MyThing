using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class SellingException : Exception
    {
        public SellingException(): base() { }

        public SellingException(String message) : base(message) { }

    }
}
