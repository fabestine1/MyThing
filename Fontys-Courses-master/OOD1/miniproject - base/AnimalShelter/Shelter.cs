using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Shelter
    {
        //private variables
        private List<Animal> animalList;
        private List<Owner> ownerList;

        //properties
        public string Name { get; }
        public string Address { get; }
        public int PhoneNr { get; }
        public string Email { get; }
        
        //constructors
        public Shelter(string name, string address, int phoneNr, string email)
        {
            Name = name;
            Address = address;
            PhoneNr = phoneNr;
            Email = email;
            animalList = new List<Animal>();
            ownerList = new List<Owner>();
        }

        //methods
        /// <summary>
        /// Adds a new animal to the shelter
        /// </summary>
        /// <param name="a">Animal object</param>
        /// <returns></returns>
        public bool AddAnimal(Animal a)
        {
            if (GetAnimal(a.RFID) == null)
            {
                animalList.Add(a);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Gets an animal by RFID tag code
        /// </summary>
        /// <param name="rfid">RFID tag code</param>
        /// <returns>Animal object</returns>
        public Animal GetAnimal(string rfid)
        {
            foreach(Animal a in animalList)
            {
                if(a.RFID == rfid) return a;
            }
            return null;
        }
        /// <summary>
        /// Adds a new owner to the shelter
        /// </summary>
        /// <param name="o">Owner object</param>
        /// <returns></returns>
        public bool AddOwner(Owner o)
        {
            if (GetOwner(o.ID) == null)
            {
                ownerList.Add(o);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Gets an owner by ID
        /// </summary>
        /// <param name="id">Owner ID</param>
        /// <returns>Owner object</returns>
        public Owner GetOwner(int id)
        {
            foreach (Owner o in ownerList)
            {
                if (o.ID == id) return o;
            }
            return null;
        }
        /// <summary>
        /// Returns a list of animals
        /// </summary>
        /// <returns>List of animals</returns>
        public List<Animal> GetAnimals()
        {
            return animalList;
        }
        /// <summary>
        /// Returns a list of owners
        /// </summary>
        /// <returns>List of owners</returns>
        public List<Owner> GetOwners()
        {
            return ownerList;
        }
        /// <summary>
        /// Returns adoptable animals for an owner
        /// </summary>
        /// <param name="ownerID">Owner ID</param>
        /// <returns>List of adoptable animals</returns>
        public List<Animal> GetAdoptableAnimals(int ownerID)
        {
            List<Animal> temp = new List<Animal>();
            foreach(Animal a in animalList)
            {
                if (a.IsAdoptable(ownerID)) temp.Add(a);
            }
            return temp;
        }
        /// <summary>
        /// Returns not-yet-adoptable animals for an owner
        /// </summary>
        /// <param name="ownerID">Owner ID</param>
        /// <returns>List of not-yet-adoptable animals</returns>
        public List<Animal> GetNotYetAdoptableAnimals(int ownerID)
        {
            List<Animal> temp = new List<Animal>();
            foreach (Animal a in animalList)
            {
                if (!a.IsAdoptable(ownerID)) temp.Add(a);
            }
            return temp;
        }
        /// <summary>
        /// Returns animals by owner
        /// </summary>
        /// <param name="ownerID">Owner ID</param>
        /// <returns></returns>
        public List<Animal> GetAnimalsByOwner(string ownerLastName)
        {
            List<Animal> temp = new List<Animal>();
            foreach (Animal a in animalList)
            {
                if (a.Owner.LastName == ownerLastName) temp.Add(a);
            }
            return temp;
        }
    }
}
