using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    class Node
    {
        public string StartupName { get; set; }
        public string DonaterName { get; set; }
        public int Amount { get; set; }
        public Node Next { get; set; }
        public Node(string startupName, string donatorName, int amount)
        {
            StartupName = startupName;
            DonaterName = donatorName;
            Amount = amount;
            Next = null;
        }
        public override string ToString()
        {
            return "Donation for " + StartupName + " from " + DonaterName + " of amount " + Amount;
        }
    }
}
