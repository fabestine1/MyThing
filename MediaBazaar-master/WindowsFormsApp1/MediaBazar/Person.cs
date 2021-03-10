using MySql.Data.MySqlClient;
using System;

namespace MediaBazar
{
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string street;
        private string postcode;
        private string region;
        private string country;
        private long phoneNumber;
        private string email;
        private string password;
        private int accountType = 0;
        private string username;
        private int departmentId = 0;
        DateTime contractStartDate;
        private decimal hourlyWage;

        public DateTime ContractStartDate
        { 
            get; 
            private set; 
        }
        public int DepartmentId 
        {
            get; 
            private set; 
        }
        public string Username
        { 
            get;
            private set; }
        public string FirstName
        {
            get;
            private set;
        }
        public string LastName 
        {
            get;
            private set;
        }
        public DateTime DateOFBirth
        {
            get;
            private set;
            }

        public string Street
        {
            get;
            private set;
        }
        public int Id
        {
            get;
            set;
        }

        public string Postcode
        {
            get;
            private set;
        }
        public string Region
        {
            get;
            private set;
        }
        public string Country
        {
            get;
            private set;
        }
        public long PhoneNumber
        {
            get;
            private set;
        }
        public string Email
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            private set;
        }
        public int AccountId
        {
            get;
            private set;
        }
        public int AccountType
        {
            get;
            private set;
        }
        public decimal HourlyWage
        {
            get;
            private set;
        }

        public Person(int accountType, string username, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, decimal hourlyWage, DateTime contractStartDate, int departmentId)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOFBirth = dateOfBirth;
            Street = street;
            Postcode = postcode;
            Region = region;
            Country = country;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            Username = username;
            AccountType = accountType;
            DepartmentId = departmentId;
            ContractStartDate = contractStartDate;
            HourlyWage = hourlyWage;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth, long phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOFBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            AddPerson();
        }

        public Person()
        {
        }

        private void AddPerson()
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string sql = "INSERT INTO person(first_name, last_name, date_of_birth, phone_number, email) VALUES (@first_name, @last_name, @date_of_birth, @phone_number, @email);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", FirstName);
                cmd.Parameters.AddWithValue("@last_name", LastName);
                cmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
                cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                cmd.Parameters.AddWithValue("@email", Email);
                conn.Open();
                cmd.ExecuteNonQuery();
                this.id = (int)cmd.LastInsertedId;
            }
            catch (Exception)
            {
                // TODO: add to error log in the future
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }
        public string GetAddress()
        {
            return street + ", " + postcode + ", " + region + ", " + country;
        }
        public virtual string ToString()
        {
            return Id + ": " + FirstName + "  " + LastName + " - " + DateOFBirth + " - " + PhoneNumber + " - " + Email;
        }
    }
}