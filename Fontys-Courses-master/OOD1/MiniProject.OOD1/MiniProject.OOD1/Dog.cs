using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Dog : Animal
    {
        //properties
        internal DateTime? LastWalkingDate { get; private set; }

        //costructors
        public Dog(string rfid, string description, string foundLocation,DateTime broughtInDate): base(rfid, description, foundLocation,broughtInDate)
        {
            LastWalkingDate = null;
        }

        //methods
        /// <summary>
        /// Calculates fee for a particular owner
        /// </summary>
        /// <returns>Fee</returns>
        public override decimal CalculateFee(int ownerID)
        {
            if(Owner.ID==ownerID)
            {
                return 10 + 2 * StayPeriod;
            }
            else
            {
                return 20;
            }
        }
        /// <summary>
        /// Updates last date of walking
        /// </summary>
        internal void UpdateLastWalkingDate()
        {
            LastWalkingDate = DateTime.Now;
        }
        /// <summary>
        /// return the information of a cat
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = "Dog. " + base.ToString();
            if (LastWalkingDate != null)
            {
                return info + ". Last walking date: " + LastWalkingDate;
            }
            return info;
        }
    }
}
