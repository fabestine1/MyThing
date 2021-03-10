using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Animal : ICalculatateFee
    {
        //properties
        protected internal string RFID { get; }
        protected internal string Description { get; set; }
        protected internal string FoundLocation { get; set; }
        protected internal DateTime BroughtInDate { get; private set; }
        protected internal Owner Owner { get; private set; }
        protected internal int StayPeriod {
            get
            {
                return Convert.ToInt32((DateTime.Now - BroughtInDate).TotalDays);
            }
        }

        //constructors
        /// <summary>
        /// Adds a new animal to the shelter
        /// </summary>
        /// <param name="rfid">RFID tag code</param>
        /// <param name="description">Animal description</param>
        /// <param name="foundLocation">Location where the animal is found</param>
        /// <returns></returns>
        protected internal Animal(string rfid, string description, string foundLocation)
        {
            RFID = rfid;
            Description = description;
            FoundLocation = foundLocation;
            BroughtInDate = DateTime.Now;
            Owner = null;
        }

        //methods
        /// <summary>
        /// Calculates fee for a particular owner
        /// </summary>
        /// <returns>Fee</returns>
        public abstract virtual decimal CalculateFee(int ownerID)
        {
            //use ownerID to check if the owner is the same as the owner of the animal
        }
        /// <summary>
        /// Checks if an animal is adoptable by a particular owner
        /// </summary>
        /// <param name="ownerID">Owner ID</param>
        /// <returns></returns>
        protected internal bool IsAdoptable(int ownerID)
        {
            //use ownerID to check if the owner is the same as the owner of the animal
        }

        /// <summary>
        /// Updates the owner
        /// </summary>
        /// <param name="o">Owner object</param>
        /// <returns></returns>
        protected internal bool Adopt(Owner o)
        {
            if (IsAdoptable(o.ID))
            {
                Owner = o;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Updates the animal description
        /// </summary>
        /// <param name="description">New description</param>
        protected internal void UpdateDescription(string description)
        {
            Description = description;
        }
        /// <summary>
        /// Updates the date of bringing in
        /// </summary>
        /// <param name="date">New date of bringing in</param>
        /// <returns></returns>
        protected internal bool UpdateBroughtInDate(DateTime date)
        {
            if(date > BroughtInDate)
            {
                BroughtInDate = date;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Updates the location of finding
        /// </summary>
        /// <param name="foundLocation">New location of finding</param>
        protected internal void UpdateFoundLocation(string foundLocation)
        {
            FoundLocation = foundLocation;
        }
    }
}
