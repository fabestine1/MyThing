using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar
{
    class EmployeeComboBoxItem
    {
        public EmployeeComboBoxItem(Employee e)
        {
            this.Id = e.EmployeeId;
            this.FirstName = e.EmployeeFirstName;
            this.LastName = e.EmployeeLastName;
            this.Username = e.EmployeeUsername;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Username { get; }

        //Override ToString method
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
