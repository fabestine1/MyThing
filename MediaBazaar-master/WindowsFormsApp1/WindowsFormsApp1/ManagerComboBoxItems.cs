using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar
{
    class ManagerComboBoxItems
    {
        public ManagerComboBoxItems(Manager m)
        {
            this.Id = m.ManagerId;
            this.FirstName = m.ManagerFirstName;
            this.LastName = m.ManagerLastName;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        //Override ToString method
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
