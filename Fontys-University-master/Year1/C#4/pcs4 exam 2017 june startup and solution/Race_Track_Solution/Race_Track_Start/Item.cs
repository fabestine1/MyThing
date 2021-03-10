using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class Item
    {

        private String participantName;

        private int numberOfWins;
 
        public String ParticipantName { get { return this.participantName; } }

        public Item(string participantName)
        {
            this.participantName = participantName;
            this.numberOfWins = 1;
        }

        public void IncrementNumberOfWins() { this.numberOfWins++; }

        public override string ToString()
        {
            return this.participantName + "; won " + this.numberOfWins + " times";
        }
        
    }
}
