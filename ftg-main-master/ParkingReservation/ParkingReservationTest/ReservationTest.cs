using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingReservation;

namespace ParkingReservationTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "parkingspot")]
        public void nullParkingspotInConstructor()
        {
            Customer cTemp = new Customer("d", true);
            Reservation r = new Reservation(null, cTemp);
        }
    }
}
