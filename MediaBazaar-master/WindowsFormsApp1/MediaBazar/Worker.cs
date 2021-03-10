using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaBazar
{
    public class Worker : Person
    {
        CreateAccount ca;
        private decimal hourlyWage = 0;

        public bool IsLoggedIn
        {
            get;
            private set;
        }

        public Worker(int accountType, string username, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, decimal hourlyWage, DateTime contractStartDate, int departmentId, bool addToDB = true)
             : base(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneNumber, email, hourlyWage, contractStartDate, departmentId)
        {
            this.hourlyWage = hourlyWage;
            if (addToDB) AddWorker();
        }
        public Worker()
        {

        }
        private void AddWorker()
        {
            int user_id = 0;
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string personSql = "INSERT INTO person(first_name, last_name, date_of_birth, street, postcode, region, country, phone_number, email) VALUES (@first_name, @last_name, @date_of_birth, @street, @postcode, @region, @country, @phone_number, @email);";
                MySqlCommand personCmd = new MySqlCommand(personSql, conn);
                personCmd.Parameters.AddWithValue("@first_name", FirstName);
                personCmd.Parameters.AddWithValue("@last_name", LastName);
                personCmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
                personCmd.Parameters.AddWithValue("@street", Street);
                personCmd.Parameters.AddWithValue("@postcode", Postcode);
                personCmd.Parameters.AddWithValue("@region", Region);
                personCmd.Parameters.AddWithValue("@country", Country);
                personCmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                personCmd.Parameters.AddWithValue("@email", Email);
                conn.Open();
                personCmd.ExecuteNonQuery();

                string userIdQuery = "SELECT id FROM person where first_name=@firstName AND last_name=@lastName AND date_of_birth=@date_of_birth AND street=@street AND postcode=@postcode AND region=@region AND country=@country AND phone_number=@phone_number AND email=@email;";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@firstName", FirstName);
                userIdCmd.Parameters.AddWithValue("@lastName", LastName);
                userIdCmd.Parameters.AddWithValue("@date_of_birth", DateOFBirth);
                userIdCmd.Parameters.AddWithValue("@street", Street);
                userIdCmd.Parameters.AddWithValue("@postcode", Postcode);
                userIdCmd.Parameters.AddWithValue("@region", Region);
                userIdCmd.Parameters.AddWithValue("@country", Country);
                userIdCmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                userIdCmd.Parameters.AddWithValue("@email", Email);
                Object userIdResult = userIdCmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    user_id = Convert.ToInt32(userIdResult);
                }

                string userSql = "INSERT INTO user(username, password, account_id, account_type) VALUES (@username, @password, @account_id, @account_type);";
                MySqlCommand userCmd = new MySqlCommand(userSql, conn);
                userCmd.Parameters.AddWithValue("@username", Username);
                userCmd.Parameters.AddWithValue("@password", Password);
                userCmd.Parameters.AddWithValue("@account_id", (int)user_id);
                userCmd.Parameters.AddWithValue("@account_type", AccountType);
                userCmd.ExecuteNonQuery();
                this.Id = (int)userCmd.LastInsertedId;

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

        public int Id
        {
            get;
            private set;
        }
        public decimal GetWage()
        {
            return this.hourlyWage;
        }

        public int WorkerRole
        {
            get;
            private set;
        }

        public static int TotalHoursWeekWorked(int workerId)
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = 0;
            try
            {
                string sql = "SELECT * FROM employee_working_days where employee_id=@id;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", workerId);
                conn.Open();

                MySqlDataReader row2 = cmd.ExecuteReader();
                while (row2.Read())  count++;
            }
            catch (Exception)
            {
                // TODO: add to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public double TotalHoursWorked()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = -1;

            try
            {
                string sql = "SELECT count(id) FROM user where username=@username and password=@password;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                Object result = cmd.ExecuteScalar();

                if (result != null) { count = Convert.ToInt32(result); }
                if (count == 1)
                {
                    string userIdQuery = "SELECT account_id FROM user where username=@username";
                    MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                    userIdCmd.Parameters.AddWithValue("@username", username);
                    Object userIdResult = userIdCmd.ExecuteScalar();
                    int user_id = 0;
                    if (userIdResult != null) { user_id = Convert.ToInt32(userIdResult); }
                    this.Id = user_id;

                    string wageQuery = "SELECT hourly_wage FROM employee_details where person_id=@user_id";

                    MySqlCommand wageCmd = new MySqlCommand(wageQuery, conn);
                    wageCmd.Parameters.AddWithValue("@user_id", user_id);

                    Object wageResult = wageCmd.ExecuteScalar();
                    decimal wage = 0;
                    if (wageResult != null) { wage = Convert.ToDecimal(wageResult); }
                    this.hourlyWage = wage;

                    string userTypeQuery = "SELECT account_type FROM user where username=@username";
                    MySqlCommand userTypeCmd = new MySqlCommand(userTypeQuery, conn);
                    userTypeCmd.Parameters.AddWithValue("@username", username);
                    Object userTypeResult = userTypeCmd.ExecuteScalar();
                    int userType = 0;
                    if (userTypeResult != null) { userType = Convert.ToInt32(userTypeResult); }
                    WorkerRole = userType;

                    string isApprovedCheck = "SELECT is_approved FROM employee_details where person_id=@person_id;";
                    MySqlCommand isApprovedCmd = new MySqlCommand(isApprovedCheck, conn);
                    isApprovedCmd.Parameters.AddWithValue("@person_id", user_id);
                    Object isApprovedResult = isApprovedCmd.ExecuteScalar();
                    int isApproved = 0;
                    if (isApprovedResult != null) { isApproved = Convert.ToInt32(isApprovedResult); }
                    if (isApproved == 1)
                    {
                        IsLoggedIn = false;
                    }
                    else if (isApproved == 2)
                    {
                        IsLoggedIn = true;
                    }
                }
            }
            catch (Exception)
            {
                IsLoggedIn = false;
            }
            finally
            {
                conn.Close();
            }
            return IsLoggedIn;
        }

        public static List<Worker> GetAllEmployeesFromDepartment(int departmentId)
        {
            MySqlConnection conn = Utils.GetConnection();
            List<Worker> emlpoyees = new List<Worker>();

            List<int> employeeid = new List<int>();
            try
            {
                string sql = "SELECT account_id FROM user WHERE account_type = 2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    int id = Convert.ToInt32(row[0]);
                    employeeid.Add(id);
                }
                conn.Close();

                string GetinfoSql = "SELECT p.id, p.first_name, p.last_name, p.date_of_birth, p.street, p.postcode, p.region, p.country, p.phone_number, p.email , ed.hourly_wage , ed.department_id , c.contract_start FROM person AS p INNER JOIN employee_details AS ed ON p.id = ed.person_id INNER JOIN contract AS c ON ed.person_id = c.person_id where department_id=@departmentId";
                MySqlCommand cmd2 = new MySqlCommand(GetinfoSql, conn);
                cmd2.Parameters.AddWithValue("@departmentId", departmentId);

                conn.Open();
                MySqlDataReader row2 = cmd2.ExecuteReader();
                while (row2.Read())
                {
                    int personid = Convert.ToInt32(row2[0]);
                    foreach (int id in employeeid)
                    {
                        if (id == personid)
                        {
                            string firstname = row2[1].ToString();
                            string lastname = row2[2].ToString();

                            DateTime dateOfBirth = Convert.ToDateTime(row2[3]);
                            string street = row2[4].ToString();
                            string postcode = row2[5].ToString();
                            string region = row2[6].ToString();
                            string country = row2[7].ToString();
                            int phonenumber = Convert.ToInt32(row2[8]);
                            string email = row2[9].ToString();
                            decimal hourly_wage = Convert.ToDecimal(row2[10]);
                            int departmentid = Convert.ToInt32(row2[11]);
                            DateTime ContractDate = Convert.ToDateTime(row2[12]);
                            Worker worker = new Worker(personid, null, null, firstname, lastname, dateOfBirth, street, postcode, region, country, phonenumber, email, hourly_wage, ContractDate, departmentid, false);
                            worker.Id = personid;
                            emlpoyees.Add(worker);

                        }
                    }
                }
            }
            catch (Exception)
            {
                // TODO: add to error log in the future
            }
            finally { conn.Close(); }

            return emlpoyees;
        }

        public static List<Worker> GetAllEmployees()
        {
            MySqlConnection conn = Utils.GetConnection();
            List<Worker> emlpoyees = new List<Worker>();

            List<int> employeeid = new List<int>();
            try
            {

                string sql = "SELECT account_id FROM user WHERE account_type = 2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    int id = Convert.ToInt32(row[0]);
                    employeeid.Add(id);
                }
                conn.Close();

                string GetinfoSql = "SELECT p.id, p.first_name, p.last_name, p.date_of_birth, p.street, p.postcode, p.region, p.country, p.phone_number, p.email , ed.hourly_wage , ed.department_id , c.contract_start FROM person AS p INNER JOIN employee_details AS ed ON p.id = ed.person_id INNER JOIN contract AS c ON ed.person_id = c.person_id WHERE ed.is_approved = 2";
                MySqlCommand cmd2 = new MySqlCommand(GetinfoSql, conn);
                conn.Open();
                MySqlDataReader row2 = cmd2.ExecuteReader();
                while (row2.Read())
                {
                    int personid = Convert.ToInt32(row2[0]);
                    foreach (int id in employeeid)
                    {
                        if (id == personid)
                        {
                            string firstname = row2[1].ToString();
                            string lastname = row2[2].ToString();

                            DateTime dateOfBirth = Convert.ToDateTime(row2[3]);
                            string street = row2[4].ToString();
                            string postcode = row2[5].ToString();
                            string region = row2[6].ToString();
                            string country = row2[7].ToString();
                            int phonenumber = Convert.ToInt32(row2[8]);
                            string email = row2[9].ToString();
                            decimal hourly_wage = Convert.ToDecimal(row2[10]);
                            int departmentid = Convert.ToInt32(row2[11]);
                            DateTime ContractDate = Convert.ToDateTime(row2[12]);
                            
                            Worker worker = new Worker(personid, null, null, firstname, lastname, dateOfBirth, street, postcode, region, country, phonenumber, email, hourly_wage, ContractDate, departmentid, false);
                            worker.Id = personid;
                            emlpoyees.Add(worker);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally { conn.Close(); }

            return emlpoyees;
        }

        public static List<Worker> GetAllManagers()
        {
            MySqlConnection conn = Utils.GetConnection();
            List<Worker> Managers = new List<Worker>();

            List<int> Managersid = new List<int>();
            try
            {

                string sql = "SELECT account_id FROM user WHERE account_type = 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    int id = Convert.ToInt32(row[0]);
                    Managersid.Add(id);
                }
                conn.Close();

                string GetinfoSql = "SELECT p.id, p.first_name, p.last_name, p.date_of_birth, p.street, p.postcode, p.region, p.country, p.phone_number, p.email , ed.hourly_wage , ed.department_id , c.contract_start FROM person AS p INNER JOIN employee_details AS ed ON p.id = ed.person_id INNER JOIN contract AS c ON ed.person_id = c.person_id WHERE ed.is_approved = 2";
                MySqlCommand cmd2 = new MySqlCommand(GetinfoSql, conn);
                conn.Open();
                MySqlDataReader row2 = cmd2.ExecuteReader();
                while (row2.Read())
                {
                    int personid = Convert.ToInt32(row2[0]);
                    foreach (int id in Managersid)
                    {
                        if (id == personid)
                        {
                            string firstname = row2[1].ToString();
                            string lastname = row2[2].ToString();

                            DateTime dateOfBirth = Convert.ToDateTime(row2[3]);
                            string street = row2[4].ToString();
                            string postcode = row2[5].ToString();
                            string region = row2[6].ToString();
                            string country = row2[7].ToString();
                            int phonenumber = Convert.ToInt32(row2[8]);
                            string email = row2[9].ToString();
                            decimal hourly_wage = Convert.ToDecimal(row2[10]);
                            int departmentid = Convert.ToInt32(row2[11]);
                            DateTime ContractDate = Convert.ToDateTime(row2[12]);
                            Worker worker = new Worker(personid, null, null, firstname, lastname, dateOfBirth, street, postcode, region, country, phonenumber, email, hourly_wage, ContractDate, departmentid, false);
                            worker.Id = personid;
                            Managers.Add(worker);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally { conn.Close(); }



            return Managers;
        }

        public static string Makequery(int weekday, string workshift)
        {
            string sql = "SELECT employee_id FROM employee_working_days WHERE ";

            if (weekday != -1 && workshift != null)
            {
                sql += "week_day_id = " + weekday + " AND shift = '" + workshift + "'";
            }
            else if (weekday == -1 && workshift != null)
            {
                sql += "shift = '" + workshift + "'";
            }
            else if (weekday != -1 && workshift == null)
            {
                sql += "week_day_id = " + weekday;
            }
            return sql;
        }

        public static List<int> GetworkerIdPerWorkday(int weekday, string workshift)
        {
            MySqlConnection conn = Utils.GetConnection();
            List<int> ids = new List<int>();
            try
            {

                string sql = Makequery(weekday, workshift);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    int personid = Convert.ToInt32(row[0]);
                    ids.Add(personid);
                }
            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally { conn.Close(); }

            return ids;
        }

        public override string ToString()
        {
            return "Worker";
        }
    }
}
