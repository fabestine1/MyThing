using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    public class StartUp : IComparable<StartUp>
    {
        private String name;        // the name of this startup
        private String description; // a short description about this startup
        private String website;     // the web-address of their website
        private int threshold;      // the minimum amount of money to start the company
        private List<Donation> donations; // the list of all donations

        public String Name { get { return this.name;  } }
        public String Description { get { return this.description; } }
        public String Website { get { return this.website; } }
        public int Threshold { get { return this.threshold; } }

        public delegate void ReachedThresholdHandler(StartUp sender);
        public event ReachedThresholdHandler ReachedThreshold;

        public StartUp(String name, String descr, String website, int threshold)
        {
            this.name = name;
            this.description = descr;
            this.website = website;
            this.threshold = threshold;
            this.donations = new List<Donation>();
        }

        /// <summary>
        /// returns the total amount of all donations
        /// </summary>
        /// <returns></returns>
        public int getTotalOfDonations()
        {
            int sum = 0;
            foreach (Donation d in this.donations) { sum += d.Amount; }
            return sum;
        }

        /// <summary>
        /// returns the number of donations
        /// </summary>
        /// <returns></returns>
        public int getNrOfDonations()
        {
            return this.donations.Count;
        }

        /// <summary>
        /// creates a donation-object and adds it to the list of donations
        /// </summary>
        /// <param name="nameDonator"></param>
        /// <param name="amount"></param>
        public void addDonation (String nameDonator, int amount)
        {
            Donation temp = new Donation(nameDonator, amount);
            this.donations.Add(temp);
            if(getTotalOfDonations() >= threshold)
            {
                if (ReachedThreshold != null) ReachedThreshold(this);
            }
        }

        /// <summary>
        /// returns a string with information about this startup
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.name +
                ", donations: " + this.getTotalOfDonations().ToString()
                + ", threshold: " + this.threshold.ToString()
                + ", " + this.description;
        }

        /// <summary>
        /// see description in exam-document
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int getSumOfDonationsAbove(int limit, int n)
        {
            if(n == 0) return 0;
            if (donations[n - 1].Amount > limit) return donations[n - 1].Amount + getSumOfDonationsAbove(limit, n - 1);
            return getSumOfDonationsAbove(limit, n - 1);
            return 99999; //todo, assignment 3a
        }

        /// <summary>
        /// see description in exam-document
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int getNumberOfTwins(int n)
        {
            if (n <= 1) return 0;
            int nrOfTwins = getNumberOfTwins(n - 1);
            if (donations[n - 1].Amount + donations[n - 2].Amount == 500) return nrOfTwins + 1;
            return nrOfTwins;
            return 99999; //todo, assignment 3b
        }

        public int CompareTo(StartUp s)
        {
            return s.getTotalOfDonations().CompareTo(getTotalOfDonations());
        }

    }
}
