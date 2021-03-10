using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaBazar
{

    class PeopleController
    {
        CreateAccount ca;

        public void ApproveFire()
        {
            throw new NotImplementedException();
        }
        public void RemoveManager()
        {
            throw new NotImplementedException();
        }
        public void GetAllFireRequests()
        {
            throw new NotImplementedException();
        }

        public void GetAllHiringRequests()
        {
            throw new NotImplementedException();
        }
        public void ApproveHire()
        {
            throw new NotImplementedException();
        }
        public void AddManager()
        {
            throw new NotImplementedException();
        }
        public void CreatePerson(string firstName, string lastName, DateTime dateOfBirth, long phoneNumber, string email)
        {
            Person person = new Person(firstName, lastName, dateOfBirth, phoneNumber, email);
        }
        public void CreateWorker(int accountType, string username, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email, decimal hourlyWage, DateTime contractStartDate, int departmentId)
        {
            Worker worker = new Worker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneNumber, email, hourlyWage, contractStartDate, departmentId);
        }

        public List<Person> GetOtherContacts()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Person> contacts = new List<Person>();
            try
            {
                string sql = "SELECT first_name, last_name,date_of_birth, phone_number,email FROM person;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    contacts.Add(new Person(row[0].ToString(), row[1].ToString(), Convert.ToDateTime(row[2]), Convert.ToInt64(row[3]), (row[4]).ToString()));
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
            return contacts;
        }
        public static List<Department> GetAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT name, description, needed_people, id FROM departments";
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
        public List<string> PopulateListBox(int user_id)
        {
            MySqlConnection conn = Utils.GetConnection();
            List<string> listContacts = new List<string>();
            try
            {

                string ShowContactsQuery = "SELECT p.id, p.first_name, p.last_name, p.date_of_birth, p.phone_number, p.email  FROM person AS p INNER JOIN contact_person AS cp ON p.id = cp.contact_person_id where employee_id=@userId;";
                MySqlCommand ShowContactsCmd = new MySqlCommand(ShowContactsQuery, conn);
                ShowContactsCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                MySqlDataReader row = ShowContactsCmd.ExecuteReader();

                while (row.Read())
                {
                    listContacts.Add("[" + row["id"].ToString() + "] " + row["first_name"] + " " + row["last_name"] + " " + "date of birth: " + row["date_of_birth"] + " " + "tel: " + row["phone_number"] + " " + "email: " + row["email"].ToString());
                }


            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return listContacts;
        }

        public int GetIdByUsername(string userName)
        {
            string username = userName;
            int user_id = 0;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string userIdQuery = "SELECT account_id FROM user where username=@username;";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object userIdResult = userIdCmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    user_id = Convert.ToInt32(userIdResult);
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
            return user_id;
        }

        public Person PopulateFields(int user_id)
        {
            Person person = null;
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string ShowContactsQuery = "SELECT  u.username, p.first_name, p.last_name, p.date_of_birth, p.phone_number, p.email, p.street, p.postcode, p.region, p.country,u.password, u.account_type, ed.hourly_wage, ed.department_id, ed.is_approved, c.contract_start FROM person AS p INNER JOIN user AS u ON p.id = u.account_id INNER JOIN  employee_details  AS ed ON ed.person_id = p.id   INNER JOIN  contract  AS c ON c.person_id = p.id  WHERE p.id=@userId;";
                MySqlCommand ShowContactsCmd = new MySqlCommand(ShowContactsQuery, conn);
                ShowContactsCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                MySqlDataReader row = ShowContactsCmd.ExecuteReader();

                while (row.Read())
                {
                    decimal wage = (Convert.ToDecimal(row["hourly_wage"]));
                    person = new Person((Convert.ToInt32(row["account_type"])), (row["username"].ToString()), (row["password"].ToString()), (row["first_name"].ToString()), (row["last_name"].ToString()), (Convert.ToDateTime(row["date_of_birth"])), (row["street"].ToString()), (row["postcode"].ToString()), (row["region"].ToString()), (row["country"].ToString()), (Convert.ToInt64(row["phone_number"])), (row["email"].ToString()), (Convert.ToDecimal(row["hourly_wage"])), (Convert.ToDateTime(row["contract_start"])), (Convert.ToInt32(row["department_id"])));
                    break;
                }

            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return person;
        }
        public List<string> PopulateShifts(int user_id)
        {
            List<string> shifts = new List<string>();
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string ShowContactsQuery = "SELECT shift FROM employee_working_days WHERE employee_id=@userId;";
                MySqlCommand ShowContactsCmd = new MySqlCommand(ShowContactsQuery, conn);
                ShowContactsCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                MySqlDataReader row = ShowContactsCmd.ExecuteReader();

                while (row.Read())
                {
                    shifts.Add((row["shift"]).ToString());

                }

            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return shifts;
        }
        public List<int> PopulateWorkdays(int user_id)
        {
            List<int> workdays = new List<int>();
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string ShowContactsQuery = "SELECT week_day_id, FROM employee_working_days WHERE employee_id=@userId;";
                MySqlCommand ShowContactsCmd = new MySqlCommand(ShowContactsQuery, conn);
                ShowContactsCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                MySqlDataReader row = ShowContactsCmd.ExecuteReader();

                while (row.Read())
                {
                    workdays.Add(Convert.ToInt32(row["week_day_id"]));

                }

            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return workdays;
        }
        public string GetDepartmentName(int user_id)
        {
            string Department = null;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string DepartmentQuery = "SELECT d.name FROM departments AS d INNER JOIN employee_details AS ed ON d.id=ed.department_id WHERE person_id=@userId;";
                MySqlCommand DepartmentCmd = new MySqlCommand(DepartmentQuery, conn);
                DepartmentCmd.Parameters.AddWithValue("@userId", user_id);
                conn.Open();
                Object departmentName = DepartmentCmd.ExecuteScalar();

                if (departmentName != null)
                {
                    Department = departmentName.ToString();
                }

            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return Department;
        }
        public int GetContractId(int person_id)
        {
            int contract_id = 0;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string userIdQuery = "SELECT id FROM contract where person_id=@person_id;";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@person_id", person_id);
                conn.Open();
                Object userIdResult = userIdCmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    contract_id = Convert.ToInt32(userIdResult);
                }
            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return contract_id;
        }
        public int GetAccountType(string username)
        {
            int accountType = 0;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                
                string accountTypeQuery = "SELECT account_type FROM user where username=@username;";
                MySqlCommand accountTypeCmd = new MySqlCommand(accountTypeQuery, conn);
                accountTypeCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object accountTypeResult = accountTypeCmd.ExecuteScalar();

                if (accountTypeResult != null)
                {
                    accountType = Convert.ToInt32(accountTypeResult);
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
            return accountType;
        }
        public void UpdateWorker(int accountType, int userId, string password, string firstName, string lastName, DateTime dateOfBirth, string street, string postcode, string region, string country, long phoneNumber, string email)
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string personSql = "UPDATE person SET first_name=@first_name, last_name=@last_name, date_of_birth=@date_of_birth, street=@street, postcode=@postcode,region=@region, country=@country, phone_number=@phone_number,email=@email where id=@id";
                MySqlCommand personCmd = new MySqlCommand(personSql, conn);
                personCmd.Parameters.AddWithValue("@first_name", firstName);
                personCmd.Parameters.AddWithValue("@last_name", lastName);
                personCmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                personCmd.Parameters.AddWithValue("@street", street);
                personCmd.Parameters.AddWithValue("@postcode", postcode);
                personCmd.Parameters.AddWithValue("@region", region);
                personCmd.Parameters.AddWithValue("@country", country);
                personCmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                personCmd.Parameters.AddWithValue("@email", email);
                personCmd.Parameters.AddWithValue("@id", userId);
                conn.Open();
                personCmd.ExecuteNonQuery();

                string userSql = "UPDATE user SET password=@password, account_type=@account_type where account_id=@account_id;";
                MySqlCommand userCmd = new MySqlCommand(userSql, conn);
                userCmd.Parameters.AddWithValue("@password", password);
                userCmd.Parameters.AddWithValue("@account_id", userId);
                userCmd.Parameters.AddWithValue("@account_type", accountType);
                userCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteShifts()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string shiftsQuery = "DELETE from employee_working_days where employee_id=@person_id;";
                MySqlCommand shiftsCmd = new MySqlCommand(shiftsQuery, conn);
                shiftsCmd.Parameters.AddWithValue("@person_id", GetIdByUsername(ca.GetUSername()));
                conn.Open();
                shiftsCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteSelectedContact(int contact_id)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string DeleteRelationQuery = "DELETE from contact_person WHERE contact_person_id=@id;";
                MySqlCommand DeleteRelationCmd = new MySqlCommand(DeleteRelationQuery, conn);
                DeleteRelationCmd.Parameters.AddWithValue("@id", contact_id);
                conn.Open();
                DeleteRelationCmd.ExecuteNonQuery();

                string DeletePersonQuery = "DELETE from person WHERE id=@id;";
                MySqlCommand DeletePersonCmd = new MySqlCommand(DeletePersonQuery, conn);
                DeletePersonCmd.Parameters.AddWithValue("@id", contact_id);
                DeletePersonCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<int> CheckExistingContacts(string userName)
        {
            MySqlConnection conn = Utils.GetConnection();
            List<int> CheckContactIds = new List<int>();

            try
            {
                string CheckContactQuery = "Select contact_person_id from contact_person WHERE employee_id=@id;";
                MySqlCommand CheckContactCmd = new MySqlCommand(CheckContactQuery, conn);
                CheckContactCmd.Parameters.AddWithValue("@id", GetIdByUsername(userName));
                conn.Open();
                MySqlDataReader Check = CheckContactCmd.ExecuteReader();

                while (Check.Read())
                {
                    CheckContactIds.Add(Convert.ToInt32(Check["contact_person_id"]));
                }

            }
            catch (Exception)
            {
                // TODO: add to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return CheckContactIds;
        }
    }
}