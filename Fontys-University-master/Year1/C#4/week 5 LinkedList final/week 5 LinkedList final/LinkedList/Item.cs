using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class Item
    {
        private String description;    // a description for this item
        private int priority;          // the priority for this item: higher number means a higher priority
        private int estimatedDuration; //the estimated duration (in minutes) of this item

        public Item(String description, int priority, int estimatedDuration)
        {
            this.description = description;
            this.priority = priority;
            this.estimatedDuration = estimatedDuration;
        }

        public String getDescription()    { return this.description;  }
        public int getPriority()          { return this.priority; }
        public int getEstimatedDuration() { return this.estimatedDuration; }

        public override string ToString()
        {
            return this.description + "; pr " + this.priority.ToString() +
                "; est " + this.estimatedDuration.ToString();
        }
    }
}
