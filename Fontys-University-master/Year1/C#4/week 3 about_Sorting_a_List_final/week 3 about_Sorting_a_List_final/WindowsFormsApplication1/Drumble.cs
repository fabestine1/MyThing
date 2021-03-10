using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Drumble : IComparable<Drumble>
    {
        private int id;
        private String name;
        private int nrOfCredits;

        public Drumble(int id, String name, int nrOfCredits)
        {
            this.id = id;
            this.name = name;
            this.nrOfCredits = nrOfCredits;
        }

        public String Name { get { return this.name; } }
        public int NrOfCredits { get { return this.nrOfCredits; } }

        public override String ToString()
        {
            return this.id + " - " + this.name + " - " + this.nrOfCredits;
        }

        //Next comment is copy&paste from the IComparable interface

        // Returns:
        //     A value that indicates the relative order of the objects being compared.
        //     The return value has these meanings: Value Meaning 
        //     Less than zero This instance is less than obj.
        //     Zero This instance is equal to obj.
        //     Greater than zero This instance is greater than obj.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     obj is not the same type as this instance.
        public int CompareTo(Drumble obj)
        {
            if (this.id < obj.id)
            {
                return -4328603;
            }
            else
            {
                if (this.id == obj.id)
                {
                    return 0;
                }
                else
                {
                    return 397;
                }
            }
            //also correct is
            // return this.id - obj.id;

        }

    }
}
