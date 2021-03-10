using System;
using System.Collections.Generic;

namespace MediaBazar
{
    class Administrator
    {
        public override string ToString()
        {
            return "Administrator";
        }

        public bool ApproveFire(Employee e)
        {
            throw new NotImplementedException();
        }

        public bool RemoveManager(Manager m)
        {
            throw new NotImplementedException();
        }

        public List<Tuple<Employee, string>> getAllFireRequests()
        {
            throw new NotImplementedException();
        }

        public List<Tuple<Employee, Department>> getAllHiringRequests()
        {
            throw new NotImplementedException();
        }

        public bool ApproveHire(Employee e)
        {
            throw new NotImplementedException();
        }

        public bool AddManager(Manager m)
        {
            throw new NotImplementedException();
        }

        public bool AddStock(Stock s)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStock(Stock s)
        {
            throw new NotImplementedException();
        }

        public bool ChangeDepartment(Employee e, Department newDepartment)
        {
            throw new NotImplementedException();
        }

        public bool CreateAccount(ProfileRoles role, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, List<Person> contactPeople = null)
        {
            throw new NotImplementedException();
        }

        public bool AddDepartment(Department d)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDepartment(Department d)
        {
            throw new NotImplementedException();
        }

        public bool MakeStockRequest(ShelfRestockRequests s)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAllWorkers()
        {
            throw new NotImplementedException();
        }

        public Employee SearchForEmployee(String firstName, String LastName)
        {
            throw new NotImplementedException();
        }

        public bool EditDepartment(Department d, String name = null, String description = null, int NeededPeople = 0)
        {
            throw new NotImplementedException();
        }

        public bool EditEmployee(String address, long phoneNumber, string email)
        {
            throw new NotImplementedException();
        }

        public bool EditStock(Stock s, string description = null, int quantityInStore = 0, Department d = null, int quantitiyInDepartment = 0)
        {
            throw new NotImplementedException();
        }

        public bool AddAnnouncement(Announcement a)
        {
            throw new NotImplementedException();
        }

        public bool ExportWorkersToExcel()
        {
            throw new NotImplementedException();
        }

    }
}
