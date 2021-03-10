using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog : Animal, ICalculatateFee
    {
        //properties
        internal DateTime? LastWalkingDate { get; private set; }

        //costructors
        internal Dog(string rfid, string description, string foundLocation): base(rfid, description, foundLocation)
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
            //use ownerID to check if the owner is the same as the owner of the animal
        }
        /// <summary>
        /// Updates last date of walking
        /// </summary>
        internal void UpdateLastWalkingDate()
        {
            LastWalkingDate = DateTime.Now;
        }
    }
}
