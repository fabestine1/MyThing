using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar
{
    class FiringRequests
    {
        private const string tableName = "firing_requests";
        public int PersonId
        {
            get;
            private set;
        }
        public int CreatedById
        {
            get;
            private set;
        }

        public string Username
        {
            get;
            private set;
        }
        public string Description
        {
            get;
            private set;
        }

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

        public int DepartmentId
        {
            get;
            private set;
        }
        public bool FrExists
        {
            get;
            private set;
        }
        public DateTime GetDateTime()
        {
            DateTime date = DateTime.Now;
            return date;
        }

        public FiringRequests(int personId, int createdById, string username, string description, string firstName, string lastName, int departmentId)
        {
            this.PersonId = personId;
            this.CreatedById = createdById;
            this.Username = username;
            this.Description = description;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DepartmentId = departmentId;
        }
        public FiringRequests(int personId, int createdById, string description)
        {
            this.PersonId = personId;
            this.CreatedById = createdById;
            this.Description = description;
            AddFiringRequest();
        }

        private void AddFiringRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = -1;
            try
            {
                string sqlCheck = "SELECT count(id) FROM firing_requests where person_id=@personId;";

                MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@personId", PersonId);
                conn.Open();

                Object result = cmdCheck.ExecuteScalar();
                if (result != null) { count = Convert.ToInt32(result); }
                if(count == 0)
                {
                    string sql = "INSERT INTO " + tableName + " (person_id, created_by_id, description) VALUES (@person_id, @created_by_id, @description);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@person_id", PersonId);
                    cmd.Parameters.AddWithValue("@description", Description);
                    cmd.Parameters.AddWithValue("@created_by_id", CreatedById);
                    int effectedRows = cmd.ExecuteNonQuery();
                    FrExists = true;
                }else
                {
                    FrExists = false;
                }
            }
            catch (Exception ex)
            {
                string epra = ex.Message;
                FrExists = false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<FiringRequests> GetAllFiringRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<FiringRequests> firingRequests = new List<FiringRequests>();
            try
            {
                string sql = "SELECT fr.person_id, fr.created_by_id, u.username, fr.description, p.first_name, p.last_name, ed.department_id FROM firing_requests AS fr INNER JOIN employee_details AS ed ON fr.person_id = ed.person_id INNER JOIN person AS p ON fr.person_id = p.id INNER JOIN user AS u ON fr.person_id = u.account_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    firingRequests.Add(new FiringRequests(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), Convert.ToInt32(row[6])));
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
            return firingRequests;
        }

        public void DeclineFiringRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE From " + tableName + " WHERE person_id = @person_Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@person_Id", PersonId);
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

        public void ApproveFiringRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE From " + tableName + " WHERE person_id = @person_Id";
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

                string contractUpdateQuery = "UPDATE contract SET contract_end = @end_date, contract_status = 2,reason_for_leaving = @description WHERE person_id = @person_id";
                MySqlCommand contractUpdateCmd = new MySqlCommand(contractUpdateQuery, conn);
                contractUpdateCmd.Parameters.AddWithValue("@end_date", GetDateTime());
                contractUpdateCmd.Parameters.AddWithValue("@description", Description);
                contractUpdateCmd.Parameters.AddWithValue("@person_id", PersonId);
                contractUpdateCmd.ExecuteNonQuery();

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
    }
}
