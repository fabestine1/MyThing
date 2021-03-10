using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PizzaShopRevisited
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private int id;
        private static int idSeeder = 1;

        public string Email
        {
            get { return email; }
            set
            {
                if (Regex.IsMatch(value, @"^[\w\d]+\@{1}[\w\d]+\.{1}[\w\d]+$"))
                    email = value;
                else
                    throw new WrongEmailException(value);
            }
        }

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = idSeeder;
            idSeeder++;
        }
        
        public Customer(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Email = email;
            this.id = idSeeder;
            idSeeder++;
        }
        public Customer(int id, string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Email = email;
            this.id = id;
            idSeeder = id + 1;
        }
        public Customer(int id, string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            idSeeder = id + 1;
        }

        public int GetCustomerId()
        {
            return this.id;
        }
        public string GetCustomerName()
        {
            return this.firstName + " " + this.lastName;
        }

        public void EditCustomerData(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
        public void EditCustomerData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
