using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCS2ExamApp
{
    class MusiciansAgency
    {
        //fields

        private string name;  //the name of this musicians agency
        private List<string> relevantInstruments;  //the instruments relevant for this musicians agency 
        private List<Musician> registeredMusicians;  //the musicians registered at this musicians agency
        private static int numberOfCreatedMusicians = 0; // counts the number of musician-objects created by all the musicians agencies 
                                                         // can also be used to generate a unique idNr for all the musicians to be added
                                                         // to registeredMusicians

        //constructor

        /// <summary>
        /// The constructor creates a musicians agency with a name as specified in the parameter and an empty list of musicians
        /// </summary>
        /// <param name="name">The name of this musicians agency</param>
        public MusiciansAgency(string name)
        {
            this.name = name;
            registeredMusicians = new List<Musician>();
            relevantInstruments = new List<string>();
        }

        //properties

        public string Name { get { return name; } }

        //methods

        /// <summary>
        /// Returns a list of all musicians
        /// </summary>
        /// <returns></returns>
        public List<Musician> GetAllMusicians()
        {
            return this.registeredMusicians;
        }

        /// <summary>
        /// Returns a list of all relevant instruments
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllRelevantInstruments()
        {
            return this.relevantInstruments;
        }

        /// <summary>
        /// If there exist a musician in the list musicians with this idNr, this method returns that musician
        /// Otherwise it returns null
        /// </summary>
        /// <param name="idNr"></param>
        /// <returns></returns>
        public Musician getMusicianWithIdnr(int idNr)
        {
            // !!!TODO!!! assignment 2a
            foreach (Musician sp in this.registeredMusicians)
            {
                if (sp.IdNr == (idNr))
                    return sp;
            }
            return null;
            // to satisfy the compiler
        
        }

        /// <summary>
        /// Adds a new musician to the list of musicians with name nm and age ag who can play the instrument instr
        /// This new musician will get an idNr that's unique in this musicians agency
        /// This idNr will be created with the help of the current value of numberOfCreatedMusicians
        /// </summary>
        /// <param name="nm">The name of the musician to be added</param>
        /// <param name="ag">The age of the musician to be added</param>
        /// <param name="instr">The instrument of the musician to be added</param>
        /// <returns></returns>
        public void AddMusician(string nm, int ag, string instr)
        {
            // !!!TODO!!! assignment 2b
            Musician holder = new Musician(nm, ag);
            numberOfCreatedMusicians++;
            holder.IdNr = numberOfCreatedMusicians;
            holder.AddInstrument(instr);
            this.registeredMusicians.Add(holder);
        }

        
        /// <summary>
        /// Adds instrument instr to the musician with idNr id if this musician exists and does not have instrument instr in his/her
        /// list possibleInstruments
        /// The method returns true if it succeeds in adding the instrument instr in this way
        /// Otherwise it returns false
        /// </summary>
        /// <param name="idNr"></param>
        /// <param name="instr"></param>
        /// <returns></returns>
        public bool AddInstrumentToMusician(int id, string instr)
        {
            // !!!TODO!!! assignment 2c
            if (getMusicianWithIdnr(id) == null)
            {
                getMusicianWithIdnr(id).AddInstrument(instr);
                return true;
            }
            // to satisfy the compiler
            return false;
        }

        /// <summary>
        /// If instr is not in relevantInstruments it adds instr to relevantInstruments and returns true
        /// Otherwise it returns false
        /// </summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        public bool AddRelevantInstrument(string instr)
        {
            foreach (string str in this.relevantInstruments)
            {
                if (str.Equals(instr))
                {
                    return false;
                }
            }
            this.relevantInstruments.Add(instr);
            return true;
        }


        /// <summary>
        /// Returns a list of all musicians in this musicians agency that can play the instrument instr
        /// </summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        public List<Musician> getMusiciansAbleToPlay(string instr)
        {
            // !!!TODO!!! assignment 2d
            List<Musician>gtas = new List<Musician>();
            foreach (Musician item in this.registeredMusicians)
            {
                if (item.CanPlay(instr))
                {
                    gtas.Add(item);
                }
            }
            return gtas;
            // to satisfy the compiler
           // return null;
        }

    }
}
