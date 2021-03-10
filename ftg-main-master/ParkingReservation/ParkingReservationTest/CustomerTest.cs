using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingReservation;

namespace ParkingReservationTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]//dit wilde je hebben!
        public void TestBalanceLowerThanZero()
        {
            Customer c = new Customer("f", true, -0.1M);

            //Assert.AreEqual(balance1, balance2);
        }
    }
}
