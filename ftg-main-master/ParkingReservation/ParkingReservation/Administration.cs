using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReservation
{
    public class Administration
    {
        public List<Reservation> Reservations { get; private set; }
        public List<ParkingSpot> ParkingSpots { get; private set; }
        public List<Customer> CustomersPermanent {get; private set; }
        public List<Customer> CustomersTemporary { get; private set; }
        public Administration()
        {
            Reservations = new List<Reservation>();
            ParkingSpots = new List<ParkingSpot>();
            CustomersPermanent = new List<Customer>();
            CustomersTemporary = new List<Customer>(); 
        }
        public bool AddCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("customer");
            }
            if(FindCustomer(customer.ID) == null)
            {
                if (customer.TemporaryCustomer)
                {
                    CustomersPermanent.Add(customer);
                }
                else
                {
                    CustomersTemporary.Add(customer);
                }
                return true;
            }
            return false;
        }
        public bool RemoveCustomer(int customerID)
        {
            if (customerID<1)
            {
                return false;
            }
            return CustomersPermanent.Remove(FindCustomer(customerID));//mag dit??
        }
        public Customer FindCustomer(string cardnumber)//moet beide customer lists gezocht worden???
        {
            if(cardnumber == "")
            {
                return null;
            }
            
            foreach(Customer c in CustomersPermanent)
            {
                foreach(string s in c.Cardnumbers)
                {
                    if(cardnumber == s)
                    {
                        return c;
                    }
                }
            }
            foreach (Customer c in CustomersTemporary)
            {
                foreach (string s in c.Cardnumbers)
                {
                    if (cardnumber == s)
                    {
                        return c;
                    }
                }
            }
            return null;
        }
        public Customer FindCustomer(int id)
        {
            if(id<=0)
            {
                return null;
            }

            foreach(Customer c in CustomersPermanent)
            {
                if(id == c.ID)
                {
                    return c;
                }
            }
            foreach (Customer c in CustomersTemporary)
            {
                if (id == c.ID)
                {
                    return c;
                }
            }
            return null;
        }
        public bool AddReservation(Reservation reservation)
        {
            if(reservation == null)
            {
                throw new ArgumentNullException("reservation");
            }
            if(FindReservationByReservation(reservation.ID) == null)
            {
                Reservations.Add(reservation);
                return true;
            }
            return false;
        }
        public bool RemoveReservationByReservation(int reservationID)
        {
            if(reservationID < 1)
            {
                return false;//argumentexception??
            }
            return Reservations.Remove(FindReservationByReservation(reservationID));
        }
        public bool RemoveReservationByCustomer(int customerID)
        {
            //customer can have multiple reservations
            if(customerID < 1)
            {
                return false;
            }

            if(FindReservationsByCustomer(customerID) == null)
            {
              return false;
            }

            List<Reservation> customerReservations = FindReservationsByCustomer(customerID);
            foreach(Reservation r in customerReservations)
            {
                Reservations.Remove(r);
            }
            return true;
        }
        public Reservation FindReservationByReservation(int reservationID)
        {
            if(reservationID < 1)
            {
                return null;
            }

            foreach (Reservation r in Reservations)
            {
                if(r.ID == reservationID)
                {
                    return r;
                }
            }
            return null;
        }
        public List<Reservation> FindReservationsByCustomer(int customerID)
        {
            if(customerID < 1)
            {
                return null;
            }
            List<Reservation> customerReservations = new List<Reservation>();
            foreach (Reservation r in Reservations)
            {
                if(r.Customer.ID == customerID)
                {
                    customerReservations.Add(r);
                }
            }
            return customerReservations;
        }
        public Reservation FindReservationByParkingSpot(int parkingSpotID)
        {
            if(parkingSpotID < 1)
            {
                return null;
            }

            foreach(Reservation r in Reservations)
            {
                if(r.ParkingSpot.ID == parkingSpotID)
                {
                    return r;
                }
            }           
            return null;
        }
        public Reservation FindReservationByParkingSpot(string parkingSpotName)
        {
            if(parkingSpotName == "")
            {
                return null;
            }

            foreach (Reservation r in Reservations)
            {
                if(r.ParkingSpot.Spotname == parkingSpotName)
                {
                    return r;
                }
            }
            return null;
        }
        public bool AddParkingSpot(ParkingSpot parkingSpot)
        {
            if(parkingSpot == null)
            {
                throw new ArgumentNullException("parkingSpot");
            }
            
            if(FindParkingSpot(parkingSpot.ID) == null)
            {
                ParkingSpots.Add(parkingSpot);
                return true;
            }
            return false;
        }
        public List<ParkingSpot> CheckFreeParkingSpots()
        {
            List<ParkingSpot> freeSpots = new List<ParkingSpot>();
            if (ParkingSpots.Count > 0)
            {
                foreach (ParkingSpot p in ParkingSpots)
                {
                    if (!p.Booked)
                    {
                        freeSpots.Add(p);
                    }
                }
                return freeSpots;
            }
            return null;
        }

        public ParkingSpot FindParkingSpot(int parkingSpotID)
        {
            if(parkingSpotID < 1)
            {
                return null;
            }

            foreach(ParkingSpot p in ParkingSpots)
            {
                if(p.ID == parkingSpotID)
                {
                    return p;
                }
            }      
            return null;      
        }

        public ParkingSpot FindParkingSpot(string spotname)
        {
            if(spotname == "")
            {
                return null;
            }

            foreach (ParkingSpot p in ParkingSpots)
            {
                if(p.Spotname == spotname)
                {
                    return p;
                }
            }
            return null;
        }

        public bool RemoveParkingSpot(int parkingSpotID)
        {
            ParkingSpot parkingSpot = FindParkingSpot(parkingSpotID);
            if(parkingSpotID > 0 && parkingSpot!=null)
            {
                return ParkingSpots.Remove(parkingSpot);
            }
            return false;
        }

        public bool RemoveParkingSpot(string spotname)
        {
            ParkingSpot parkingSpot = FindParkingSpot(spotname);
            if (spotname != "" && parkingSpot != null)
            {
                return ParkingSpots.Remove(parkingSpot);
            }
            return false;
        }

        public bool RemoveParkingSpot(ParkingSpot parkingSpot)
        {
            if(parkingSpot == null)
            {
                throw new ArgumentNullException("parkingspot");
            }
            return ParkingSpots.Remove(parkingSpot);
        }
        public enum TYPE
        {
            Customer,
            Reservation,
            ParkingSpot
        }

        public string ToString(TYPE t)
        {
            string AcquiredInfo = "Nothing Found";
            string objects = "No objects found";
            int index = 0;
            switch(t)
            {
                case TYPE.Customer:
                    index = CustomersPermanent.Count() + CustomersPermanent.Count();
                    if (index > 0)
                    {
                        objects = "";
                        foreach (Customer c in CustomersPermanent)
                        {
                            objects += CustomersPermanent.IndexOf(c).ToString()+ ") "+ c.ToString() + "\n";
                        }
                        
                        foreach (Customer c in CustomersTemporary)
                        {
                            objects += (CustomersPermanent.Count() + CustomersTemporary.IndexOf(c)).ToString() + ") " + c.ToString() + "\n";
                        }       
                    }
                    else
                    {
                        objects = "No customers found";
                    }
                    AcquiredInfo = "Customers<" +index+">: \n" + objects;                 
                    break;

                case TYPE.ParkingSpot:
                    index = ParkingSpots.Count();
                    if (index > 0)
                    {
                        objects = "";
                        foreach (ParkingSpot p in ParkingSpots)
                        {
                            objects += ParkingSpots.IndexOf(p).ToString()+ ") "+ p.ToString() + "\n";
                        }
                    }
                    else
                    {
                        objects = "No parkingSpots found";
                    }
                    AcquiredInfo = "ParkingSpots<" +index+">: \n" + objects;  
                    break;

                case TYPE.Reservation:
                    index = Reservations.Count();
                    if (index > 0)
                    {
                        objects = "";
                        foreach (Reservation r in Reservations)
                        {
                            objects += Reservations.IndexOf(r).ToString() + ") " + r.ToString() + "\n";
                        }
                    }
                    else
                    {
                        objects = "No Reservations found";
                    }
                    AcquiredInfo = "Reservations<" + index + ">: \n" + objects;
                    break;
            }
            return AcquiredInfo;
        }
        public override string ToString()
        {
            string customers = "Amount of customers: <" + (CustomersPermanent.Count + 
                   CustomersTemporary.Count).ToString() + ">\n";
            string reservations = "Amount of reservations: <" + Reservations.Count.ToString() + ">\n";
            string parkingspots = "Amount of parkingspots: <" + ParkingSpots.Count.ToString() + ">\n";
            
            string info = "Administration info:\n"  + 
                    customers + reservations +
                    parkingspots;
            return info;
        }

    }
}
