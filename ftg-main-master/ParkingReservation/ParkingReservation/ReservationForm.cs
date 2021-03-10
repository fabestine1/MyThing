using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingReservation
{
    public partial class ReservationForm : Form
    {
        Administration Administration;
        public ReservationForm()
        {
            InitializeComponent();
            Administration = new Administration();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customerLoyalNotTemp = new Customer("Customer Loyal NotTemp ID1",false, 111.30M, "aX 00 32");
            customerLoyalNotTemp.LoyalCustomer = true;

            Customer customerNotLoyalTemp = new Customer("Customer Not Loyal Temp ID2", true, 300.30M, "aX 11 99");
            customerNotLoyalTemp.AddCard("dd dd");

            Administration.AddCustomer(customerLoyalNotTemp);
            Administration.AddCustomer(customerNotLoyalTemp);

            ParkingSpot p1 = new ParkingSpot("Spot1");
            ParkingSpot p2 = new ParkingSpot("Spot2");
            Administration.AddParkingSpot(p1);
            Administration.AddParkingSpot(p2);

            Reservation r1 = new Reservation(p1, customerLoyalNotTemp);
            Reservation r2 = new Reservation(p2, customerNotLoyalTemp);
            Administration.AddReservation(r1);
            Administration.AddReservation(r2);

            MessageBox.Show(Administration.ToString());

            /*
            MessageBox.Show(Administration.ToString(Administration.TYPE.Customer));
            MessageBox.Show(Administration.ToString(Administration.TYPE.ParkingSpot));
            MessageBox.Show(Administration.ToString(Administration.TYPE.Reservation)); */      
        }
    }
}
