using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaBazar
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string EmployeeFirstName { get; private set; }
        public string EmployeeLastName { get; private set; }
        public string EmployeeUsername { get; private set; }
        public Employee(int employeeId, string firstName, string lastName, string username)
        {
            this.EmployeeId = employeeId;
            this.EmployeeFirstName = firstName;
            this.EmployeeLastName = lastName;
            this.EmployeeUsername = username;
        }

        public static List<Employee> GetAllEmployees()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = "SELECT p.id, p.first_name, p.last_name, u.username FROM person AS p INNER JOIN user AS u ON p.id = u.account_id INNER JOIN employee_details AS ep ON p.id = ep.person_id WHERE u.account_type = 2 AND ep.is_approved = 2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    employees.Add(new Employee(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString()));
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
            return employees;
        }
        public override string ToString()
        {
            return "Employee";
        }
    }
}
