using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
   public class CrowdFunding
    {
        private List<StartUp> startups;  //a list of startup-objects

        public CrowdFunding()
        {
            this.startups = new List<StartUp>();
        }

        /// <summary>
        /// returns a lis of all startups
        /// </summary>
        /// <returns></returns>
        public List<StartUp> getAllStartups()
        {
            return this.startups;
        }

        /// <summary>
        /// if the list contains a startup-object with name equal to nm,
        /// then that startup-object is returned,
        /// else the return-value is null
        /// </summary>
        /// <param name="nm"></param>
        /// <returns></returns>
        public StartUp getStartup(String nm)
        {
            foreach (StartUp s in this.startups)
            {
                if (s.Name == nm) { return s; }
            }
            return null;
        }

        /// <summary>
        /// adds startup s to the list
        /// </summary>
        /// <param name="s"></param>
        public void addStartup(StartUp s)
        {
                this.startups.Add(s);
        }

        /// <summary>
        /// see description in exam-document
        /// </summary>
        public void SortOnTotalDonations()
        {
            //todo, assignment 1
            this.startups.Sort();
        }

        /// <summary>
        /// see description in exam-document
        /// </summary>
        public void sortOnNumberOfDonations_Name()
        {
            //todo, assignment 1
            this.startups.Sort(new Comparison<StartUp>(mySortMethod));
        }
        public int mySortMethod(StartUp firstStartup, StartUp secondStartup)
        {
            int differenceNrOfDonations = firstStartup.getNrOfDonations() - secondStartup.getNrOfDonations();
            if (differenceNrOfDonations != 0) { return differenceNrOfDonations; }
            else { return firstStartup.Name.CompareTo(secondStartup.Name); }
        }
    }
}
