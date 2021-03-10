using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazar
{
    public class Manager 
    {
        public int ManagerId { get; private set; }
        public string ManagerFirstName { get; private set; }
        public string ManagerLastName { get; private set; }

        public Manager(int managerId, string firstName, string lastName)
        {
            this.ManagerId = managerId;
            this.ManagerFirstName = firstName;
            this.ManagerLastName = lastName;
        }

        public static List<Manager> GetAllManagers()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Manager> managers = new List<Manager>();
            try
            {
                string sql = "SELECT p.id, p.first_name, p.last_name, u.username FROM person AS p INNER JOIN user AS u ON p.id = u.account_id INNER JOIN employee_details AS ep ON p.id = ep.person_id WHERE u.account_type = 1 AND ep.is_approved = 2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    managers.Add(new Manager(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString()));
                }
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return managers;
        }
        public override string ToString()
        {
            return "Manager";
        }

        public List<Tuple<Employee, string>> SendFiringRequest(Employee e, string reason = null)
        {
            throw new NotImplementedException();
        }

        public List<Tuple<Employee, Department>> SendHiringRequest(Employee e, Department d)
        {
            throw new NotImplementedException();
        }

        public bool CreateEmployee(string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, List<Person> contactPeople = null)
        {
            throw new NotImplementedException();
        }

        public bool MakeStockRequest(ShelfRestockRequests s)
        {
            throw new NotImplementedException();
        }

        public Employee SearchForEmployee(String firstName, String LastName)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetDepartmentStocks(Department d)
        {
            throw new NotImplementedException();
        }
        public bool AddStock(Stock s)
        {
            throw new NotImplementedException();
        }

        internal static List<Manager> GetAllManagersByDepartment(int departmentId)
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Manager> managers = new List<Manager>();
            try
            {
                string sql = "SELECT p.id, p.first_name, p.last_name, u.username FROM person AS p INNER JOIN user AS u ON p.id = u.account_id INNER JOIN employee_details AS ep ON p.id = ep.person_id WHERE u.account_type = 1 AND ep.is_approved = 2 AND ep.department_id=@department_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", departmentId);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    managers.Add(new Manager(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString()));
                }
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return managers;
        }
    }
}
