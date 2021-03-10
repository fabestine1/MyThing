using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication2
{
    [Serializable]
    class ManufacturingCompany
    {
        /************datafields*******************************************/
        private String name;
        private List<Machine> machines;

        /************constructor******************************************/
        public ManufacturingCompany(String name)
        {
            this.name = name;
            this.machines = new List<Machine>();
        }

        /************properties*******************************************/
        public String Name { get { return name; } }
        public List<Machine> Machines { get { return machines; } }

        /************methods*********************************************/

        /// <summary>
        /// if there exists a machine with name equal to nm, that particular machine is returned
        /// else null is returned
        /// </summary>
        /// <param name="nm"></param>
        /// <returns></returns>
        public Machine GetMachine(String nm)
        {
            foreach (Machine m in machines)
            {
                if (m.Name == nm) { return m; }
            }
            return null;
        }
        
        /// <summary>
        /// if there is no machine with name equal to m.Name, then m is added and the returnvalue is true
        /// else nothing is added and the returnvalue is false
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool AddMachine(Machine m)
        {
            if (this.GetMachine(m.Name) == null)
            {
                machines.Add(m); return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// returns the name and the number of machines
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Company: " + this.name + " with " + this.machines.Count.ToString() + " machines.";
        }
    }
}
