using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterWeek1
{
    class Animal
    {
        public string RegNumber { get; set; }
        public DateTime DateBrought { get; set; }
        public string Name { get; set; }
        public string NameNewOwner { get; set; }
        public Animal (string regNum, DateTime brought, string name)
        {
            RegNumber = regNum;
            DateBrought = brought;
            Name = name;
        }
        public void RegisterNewOwner(string ownerName)
        {
            NameNewOwner = ownerName;
        }
        public bool IsAdopted()
        {
            if(NameNewOwner != null)
            {
                return true;
            }
            return false;
        }
        public virtual string AsString()
        {
            string info = "";
            info = RegNumber + ", " + DateBrought + ", " + Name + ", ";
            if (IsAdopted())
            {
                info += "reserved, ";
            }
            else
            {
                info += "not reserved, ";
            }
            return info;
        }
    }
}
