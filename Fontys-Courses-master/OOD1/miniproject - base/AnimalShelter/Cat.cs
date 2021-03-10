using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat: Animal, ICalculatateFee
    {
        //properties
        internal string ExtraInfo { get; set; }

        //costructors
        internal Cat(string rfid, string description, string foundLocation, string extraInfo) : base(rfid, description, foundLocation)
        {
            ExtraInfo = extraInfo;
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
        internal void UpdateExtraInfo(string extraInfo)
        {
            ExtraInfo = extraInfo;
        }
    }
}
