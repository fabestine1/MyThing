using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaBazar
{
    public class Department
    {
        private const string tableName = "departments";
        public int DepartmentId
        {
            get;
            private set;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NeededPeople { get; set; }

        public Department(string name, string description, int neededPeople)
        {
            this.Name = name;
            this.Description = description;
            this.NeededPeople = neededPeople;
            AddDepartment();
        }

        public Department(string name, string description, int neededPeople, int id)
        {
            this.Name = name;
            this.Description = description;
            this.NeededPeople = neededPeople;
            this.DepartmentId = id;
        }

        public static int GetNeededPeopleCount(int departmentId)
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = 0;
            try
            {
                string sql = "SELECT needed_people FROM " + tableName + " WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", departmentId);
                conn.Open();
                count = (Int32)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        internal static bool[] GetWorkersShifts(int workerId)
        {
            MySqlConnection conn = Utils.GetConnection();

            bool[] days = new bool[7];

            try
            {
                String sql = "SELECT week_day_id FROM `employee_working_days` where `employee_id` = @id group by week_day_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", workerId);
                conn.Open();

                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    days[Convert.ToInt32(row["week_day_id"])] = true;
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
            return days;
        }

        internal static int[] GetWorkersCountFor(int departmentId, string shift)
        {
            MySqlConnection conn = Utils.GetConnection();
            Int32 count = 0;
            int[] days = new int[8];

            try
            {
                String sql = "";
                switch (shift)
                {
                    case "morning":
                        sql = "SELECT * FROM employee_details left join person p on person_id=p.id left join employee_working_days wd on wd.employee_id = p.id where department_id = @departmentId and shift = 'morning'";
                        break;
                    case "afternoon":
                        sql = "SELECT * FROM employee_details left join person p on person_id=p.id left join employee_working_days wd on wd.employee_id = p.id where department_id = @departmentId and shift = 'afternoon'";
                        break;
                    case "evening":
                        sql = "SELECT * FROM employee_details left join person p on person_id=p.id left join employee_working_days wd on wd.employee_id = p.id where department_id = @departmentId and shift = 'evening'";
                        break;

                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@departmentId", departmentId);
                conn.Open();

                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    days[Convert.ToInt32(row["week_day_id"])] += 1;
                    count += 1;
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
            days[7] = count;
            return days;
        }

        public Department(string name, int neededPeople)
        {
            this.Name = name;
            this.NeededPeople = neededPeople;
            AddDepartment();
        }

        internal static Department GetDepartmentById(int departmentId)
        {
            MySqlConnection conn = Utils.GetConnection();

            Department department = null;
            try
            {
                string sql = "SELECT name, description, needed_people, id FROM " + tableName + " WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", departmentId);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    department = new Department(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2]), Convert.ToInt32(row[3]));
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
            return department;
        }

        public List<Employee> GetDepartmentEmployees()
        {
            throw new NotImplementedException();
        }

        public static List<Employee> GetDepartmentEmployees(Department d)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetDepartmentManagers()
        {
            throw new NotImplementedException();
        }

        public static List<Manager> GetDepartmentManagers(Department d)
        {
            throw new NotImplementedException();
        }

        private bool AddDepartment()
        {
            MySqlConnection conn = Utils.GetConnection();
            
            try
            {
                string sql = "INSERT INTO " + tableName + "(name , description , needed_people) VALUES (@name, @description ,@needed_people);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@description", Description);
                cmd.Parameters.AddWithValue("@needed_people", NeededPeople);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public static bool AddDepartment(Department d)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO " + tableName + "(name , description , needed_people) VALUES (@name, @description ,@needed_people);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", d.Name);
                cmd.Parameters.AddWithValue("@description", d.Description);
                cmd.Parameters.AddWithValue("@needed_people", d.NeededPeople);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool RemoveDepartment()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE From " + tableName + " WHERE id = @depId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@depId", DepartmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public static bool RemoveDepartment(Department d)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE From " + tableName + " WHERE id = @depId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@depId", d.DepartmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public void EditDepartment(string name, string description, int neededpeople)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "UPDATE " + tableName + " SET name = @name, description = @description, needed_people = @needed_people WHERE id = @departmentId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@needed_people", neededpeople);
                cmd.Parameters.AddWithValue("@departmentId", DepartmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }

        }

        public static List<Department> GetAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT name, description, needed_people, id FROM " + tableName;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    departments.Add(new Department(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2]), Convert.ToInt32(row[3])));
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
            return departments;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}