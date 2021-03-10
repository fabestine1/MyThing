using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    // 
    public class Participant
    {
        // fields
        private int id; // the id of the participant
        private String name; // the name of the participant

        // constructor
        public Participant(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        // methods

        /// <summary>
        /// GetId()
        /// returns the id of the participant
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this.id;
        }
    }
}
