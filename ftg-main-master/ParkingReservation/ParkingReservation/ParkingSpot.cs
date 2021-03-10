using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReservation
{
    public class ParkingSpot
    {
        private static int nextID;//automatically initialised at 0
        public int ID { get; private set; }
        public string Spotname { get; private set; }
        public bool Booked { get; private set; }

        public ParkingSpot(string spotname)
        {
            if (spotname == null || spotname.Length == 0)
            {
                //exception invalidagument
            }

            this.ID = ++nextID;//first add 1 to nextID before assigning to ID
            this.Spotname = spotname;
            Booked = false;//vanuit arduino input voor bezette plaatsen.
        }

        public override string ToString()
        {
            string ID = "ID: " + this.ID.ToString();
            string name = "Spotname: " + Spotname.ToString();
            string booked = "Booked: " + Booked.ToString();
            
            string spotInfo = ID + ", " + 
                              name + ", " +
                              booked;
            return spotInfo;
        }
    }
}
