using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCS2ExamApp
{
    class Musician
    {
        //fields
        
        private string name;  //the name of the musician
        private int idNr;  //could be used for some identity information of the musician
        private int age;  //the age of the musician, in years
        private List<string> possibleInstruments; //the instruments the musician can play

        //constructor
        
        /// <summary>
        /// This constructor creates a musician with a name and an age as specified in the parameters
        /// If the age specified in the parameter is negative the age of the musician will be -1, which stands for unknown
        /// The idnr will be -1, which stands for unknown
        /// The list of instruments he/she can play is (still) empty.
        /// </summary>
        /// <param name="name">The name of this musician</param>
        /// <param name="age">The age of this musician</param>
        public Musician(string name, int age)
        {
            // !!!TODO!!! assignment 1a
            this.name = Name;
            this.idNr = -1;
            possibleInstruments = new List<String>();
            if (age < 0)
            {
                this.age = -1;

            }
            else
            {
                this.age = age;
            }
        }

        //properties
        
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public int IdNr
        { 
            get { return idNr; }
            set { idNr = value; }
        }

        //methods

        /// <summary>
        /// Returns all instruments he/she can play
        /// </summary>
        /// <returns></returns>
        public List<string> getAllInstruments()
        {
            return this.possibleInstruments;
        }


        /// <summary>
        /// If there is no instrument in the list possibleInstruments equal to newInstrument, add the new instrument
        /// to possibleInstruments and return true.
        /// If there is already an instrument in the list possibleInstruments equal to newInstrument, return false
        /// </summary>
        /// <param name="newInstrument">The new instrument to be added to the list</param>
        /// <returns></returns>
        public bool AddInstrument(string newInstrument)
        {
            //!!!TODO!!! assignment 1b
            foreach (string item in possibleInstruments)
            {
                if (item == newInstrument)
                {
                    possibleInstruments.Add(newInstrument);
                    return true;
                }
            }
            // to satisfy the compiler
            return false;
        }

        /// <summary>
        /// If the list possibleInstruments contains someInstrument, this method returns true. Otherwhise it returns false
        /// </summary>
        /// <param name="someInstrument">The instrument to be investigated</param>
        /// <returns></returns>        
        public bool CanPlay(string someInstrument)
        {
            // !!!TODO!!! assignment 1c
            foreach (string item in possibleInstruments)
            {
                if (item.Contains (someInstrument))
                {
                    return true;
                }
                
            }
            return false;

            // to satisfy the compiler
           
        }

        /// <summary>
        /// Returns a string with information about the musician: first his/her name,
        /// then his/her age and then all the instruments he/she can play.
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            string holder = "name: " + this.name + "; age: " + this.age.ToString() + "; instruments: ";

            bool firstInstrument = true;
            foreach (string ins in this.possibleInstruments)
            {
                if (firstInstrument)
                {
                    holder = holder + ins;
                    firstInstrument = false;
                }
                else
                {
                    holder = holder + ", " + ins;
                }
            }
            if (this.idNr == -1)
            {
                holder = holder + "; (idNr: unknown)";
            }
            else
            {
                holder = holder + "; (idNr: " + this.idNr.ToString() + ")";
            }
            return holder;
        }
    }

}
