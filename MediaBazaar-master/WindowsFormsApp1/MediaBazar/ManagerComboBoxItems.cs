using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar
{
    class ManagerComboBoxItems
    {
        private string firstName;
        private string lastName;
        private int id;

        public ManagerComboBoxItems(Manager m)
        {
            this.id = m.ManagerId;
            this.firstName = m.ManagerFirstName;
            this.lastName = m.ManagerLastName;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
