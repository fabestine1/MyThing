using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazar
{
    class HiringRequests
    {
        public int PersonId { get; private set; }
        public int CreatedById { get; private set; }
        public string Username { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal HourlyWage { get; private set; }
        public int DepartmentId { get; private set; }
        public bool FrExists { get; private set; }
        public DateTime ContractStartDate { get; private set; }
        public long PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public HiringRequests(int personId, int createdById, string username, string firstName, string lastName, decimal hourlyWage, int departmentId, DateTime contractStartDate, long phoneNumber, string email)
        {
            this.PersonId = personId;
            this.CreatedById = createdById;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HourlyWage = hourlyWage;
            this.DepartmentId = departmentId;
            this.ContractStartDate = contractStartDate;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        public HiringRequests(int personId, int createdById)
        {
            this.PersonId = personId;
            this.CreatedById = createdById;
            AddHiringRequest();
        }
        private void AddHiringRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = -1;
            try
            {
                string sqlCheck = "SELECT count(id) FROM hiring_requests where person_id=@personId;";

                MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@personId", PersonId);
                conn.Open();

                Object result = cmdCheck.ExecuteScalar();
                if (result != null) { count = Convert.ToInt32(result); }
                if (count == 0)
                {
                    string sql = "INSERT INTO hiring_requests (person_id, created_by_id) VALUES (@person_id, @created_by_id);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@person_id", PersonId);
                    cmd.Parameters.AddWithValue("@created_by_id", CreatedById);
                    int effectedRows = cmd.ExecuteNonQuery();
                    FrExists = true;
                }
                else
                {
                    FrExists = false;
                }
            }
            catch (Exception)
            {
                FrExists = false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<HiringRequests> GetAllHiringRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<HiringRequests> hiringRequests = new List<HiringRequests>();
            try
            {
                string sql = "SELECT hr.person_id, hr.created_by_id, u.username, p.first_name, p.last_name, ed.hourly_wage, ed.department_id, c.contract_start, p.phone_number, p.email FROM hiring_requests AS hr INNER JOIN employee_details AS ed ON hr.person_id = ed.person_id INNER JOIN person AS p ON hr.person_id = p.id INNER JOIN user AS u ON hr.person_id = u.account_id INNER JOIN contract AS c ON hr.person_id = c.person_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    hiringRequests.Add(new HiringRequests(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), row[2].ToString(), row[3].ToString(), row[4].ToString(), Convert.ToDecimal(row[5]), Convert.ToInt32(row[6]), Convert.ToDateTime(row[7]), Convert.ToInt64(row[8]), row[9].ToString()));
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
            return hiringRequests;
        }

        public void DeclineHiringRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE From hiring_requests WHERE person_id = @person_Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@person_Id", PersonId);
                conn.Open();
                cmd.ExecuteNonQuery();

                string userRemoveQuery = "DELETE From user WHERE account_id = @person_Id";
                MySqlCommand userRemoveCmd = new MySqlCommand(userRemoveQuery, conn);
                userRemoveCmd.Parameters.AddWithValue("@person_Id", PersonId);
                userRemoveCmd.ExecuteNonQuery();

                string employeeRemoveQuery = "DELETE From employee_details WHERE person_id = @person_Id";
                MySqlCommand employeeRemoveCmd = new MySqlCommand(employeeRemoveQuery, conn);
                employeeRemoveCmd.Parameters.AddWithValue("@person_Id", PersonId);
                employeeRemoveCmd.ExecuteNonQuery();

                string employeeDaysRemoveQuery = "DELETE From employee_working_days WHERE employee_id = @person_Id";
                MySqlCommand employeeDaysRemoveCmd = new MySqlCommand(employeeDaysRemoveQuery, conn);
                employeeDaysRemoveCmd.Parameters.AddWithValue("@person_Id", PersonId);
                employeeDaysRemoveCmd.ExecuteNonQuery();

                string employeeContactRemoveQuery = "DELETE From contact_person WHERE employee_id = @person_Id";
                MySqlCommand employeeContactRemoveCmd = new MySqlCommand(employeeContactRemoveQuery, conn);
                employeeContactRemoveCmd.Parameters.AddWithValue("@person_Id", PersonId);
                employeeContactRemoveCmd.ExecuteNonQuery();

                string contractRemoveQuery = "DELETE From contract WHERE person_id = @person_Id";
                MySqlCommand contractRemoveCmd = new MySqlCommand(contractRemoveQuery, conn);
                contractRemoveCmd.Parameters.AddWithValue("@person_id", PersonId);
                contractRemoveCmd.ExecuteNonQuery();

                string personRemoveQuery = "DELETE From person WHERE id = @person_Id";
                MySqlCommand personRemoveCmd = new MySqlCommand(personRemoveQuery, conn);
                personRemoveCmd.Parameters.AddWithValue("@person_id", PersonId);
                personRemoveCmd.ExecuteNonQuery();
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
        public void ApproveHiringRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string updateIsApprovedQuery = "UPDATE employee_details SET is_approved=@is_approved WHERE person_id=@person_id";
                MySqlCommand updateIsApprovedCmd = new MySqlCommand(updateIsApprovedQuery, conn);
                updateIsApprovedCmd.Parameters.AddWithValue("@person_id", PersonId);
                updateIsApprovedCmd.Parameters.AddWithValue("@is_approved", 2);
                conn.Open();
                updateIsApprovedCmd.ExecuteNonQuery();

                string sql = "DELETE From hiring_requests WHERE person_id = @person_Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@person_Id", PersonId);
                cmd.ExecuteNonQuery();
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
    }
}
