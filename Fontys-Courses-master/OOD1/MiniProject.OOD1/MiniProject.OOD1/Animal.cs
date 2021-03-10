using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public abstract class Animal
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
        protected internal bool Adopted { get; private set; }
        protected internal bool Claimed { get; private set; }
        //constructors
        /// <summary>
        /// Adds a new animal to the shelter
        /// </summary>
        /// <param name="rfid">RFID tag code</param>
        /// <param name="description">Animal description</param>
        /// <param name="foundLocation">Location where the animal is found</param>
        /// <returns></returns>
        protected internal Animal(string rfid, string description, string foundLocation, DateTime BroughtinDate)
        {
            RFID = rfid;
            Description = description;
            FoundLocation = foundLocation;
            BroughtInDate = BroughtinDate;
            Owner = null;
            Adopted = false;
            Claimed = false;
        }

        //methods
        /// <summary>
        /// Checks if an animal is adoptable by a particular owner
        /// </summary>
        /// <param name="ownerID">Owner ID</param>
        /// <returns></returns>
        protected internal bool IsAdoptable(int ownerID)
        {
            if (Owner==null)
            {
                if(StayPeriod>20&&!Adopted)
                return true;
            }
            else
            {
                if (StayPeriod > 20 && !Adopted)
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if an animal is claimable by a particular owner
        /// </summary>
        /// <param name="ownerID">Owner ID</param>
        /// <returns></returns>
        protected internal bool IsClaimable(int ownerID)
        {
            if(Owner!=null&&Owner.ID==ownerID)
            {
                if(StayPeriod<=20&&!Claimed||StayPeriod>20&&!Claimed&&!Adopted)
                return true;
            }
            return false;           
        }

        /// <summary>
        /// Adopt an animal
        /// </summary>
        /// <param name="o">Owner object</param>
        /// <returns></returns>
        public bool Adopt(Owner o,ref decimal fee)
        {
            if (IsAdoptable(o.ID))
            {
                UpdateOwner(o);
                fee = CalculateFee(o.ID);
                Adopted = true;
                return true;
              
            }
            return false;
        }
        /// <summary>
        /// Claim an animal
        /// </summary>
        /// <param name="o">Owner object</param>
        /// <returns></returns>
        public bool Claim(Owner o,ref decimal fee)
        {
            if (IsClaimable(o.ID))
            {
                fee = CalculateFee(o.ID);
                Claimed = true;
                return true;
            }
            return false;
        }

        //methods
        /// <summary>
        /// Calculates fee for a particular owner
        /// </summary>
        /// <returns>Fee</returns>
        public abstract decimal CalculateFee(int ownerID);//use ownerID to check if the owner is the same as the owner of the animal
    

        /// <summary>
        /// Updates the information of animal
        /// </summary>
        /// <returns></returns>
        public virtual void UpdateInfo(DateTime date, string foundLocation, string description)
        {
            if(date > BroughtInDate)
            {
                BroughtInDate = date;
            }
            FoundLocation = foundLocation;
            Description = description;
        }

        /// <summary>
        /// Updates the owner of animal
        /// </summary>
        /// <returns></returns>
        public virtual void UpdateOwner(Owner o)
        {
            Owner = o;
        }

        /// <summary>
        /// return the infomation of animal
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = "Description: " + Description + ". Found location: " + FoundLocation + ". Brought in date: " + BroughtInDate;
            if (Owner != null)
            {
                return info+ ". Owner ID: "+Owner.ID;
            }
            return info;

        }

    }
}
