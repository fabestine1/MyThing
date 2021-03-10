using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat: Animal
    {
        //properties
        internal string ExtraInfo { get; set; }

        //costructors
        public Cat(string rfid, string description, string foundLocation, string extraInfo,DateTime broughtInDate) : base(rfid, description, foundLocation,broughtInDate)
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
            if(Owner!=null&&Owner.ID==ownerID)
            {
                return 15;
            }
            else
            {
                return 25;
            }
        }
        /// <summary>
        /// return the information of a cat
        /// </summary>
        /// <returns></returns>
        public void updateExtraInfo(string extraInfo)
        {
            ExtraInfo = extraInfo;
        }
        /// <summary>
        /// return the information of a cat
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Cat. " + base.ToString() + ". Extra information: " + ExtraInfo;
        }


    }
}
