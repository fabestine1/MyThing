using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReservation
{
    public class Reservation
    {
        public int ID { get; private set; }

        private static int nextID;
        public DateTime ReservationDate { get; private set; }
        public ParkingSpot ParkingSpot { get; private set; }
        public Customer Customer { get; private set; }


        public Reservation(ParkingSpot parkingSpot, Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("customer");
            }
            if (parkingSpot == null)
            {
                throw new ArgumentNullException("parkingspot");
            }

            this.Customer = customer;
            this.ParkingSpot = parkingSpot;

            this.ReservationDate = DateTime.Now;
            this.ID = ++nextID;
        }
        /// <summary>
        /// gives amount of customers, reservations and parkingspots in this class
        /// </summary>
        /// <returns>string with amount of customers, reservations and parkingspots</returns>
        public override string ToString()
        {
            string ID = "ID: " + this.ID.ToString();
            string customerName = "Customername: " + Customer.Name;
            string parkingspotName = "Parkingspot: " + ParkingSpot.Spotname;
            string reservationDate = "Reservation Date: " + ReservationDate.ToString();

            string spotInfo = ID + ", " +
                              customerName + ", " +
                              parkingspotName + ", " +
                              reservationDate;
            return spotInfo;
        }
    }
}
