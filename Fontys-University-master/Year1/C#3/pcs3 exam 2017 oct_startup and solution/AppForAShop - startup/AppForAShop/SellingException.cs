using System;
using System.Runtime.Serialization;

namespace AppForAShop
{
    [Serializable]
    internal class SellingException : Exception
    {

        public SellingException() : base() { }

        public SellingException(String message) : base(message) { }
    }
}