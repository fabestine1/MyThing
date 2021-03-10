using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazar
{
    class PromotionRequests
    {
        private const string tableName = "promotion_requests";
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
        public bool PrExists
        {
            get;
            private set;
        }
        public decimal HourlyWage
        {
            get;
            private set;
        }
        public DateTime GetDateTime()
        {
            DateTime date = DateTime.Now;
            return date;
        }
        public PromotionRequests(int personId, int createdById, string username, string firstName, string lastName, int departmentId,decimal hourlywage)
        {
            this.PersonId = personId;
            this.CreatedById = createdById;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HourlyWage = hourlywage;
            this.DepartmentId = departmentId;
        }
        public PromotionRequests(int personId, int createdById,decimal HourlyWage)
        {
            this.PersonId = personId;
            this.CreatedById = createdById;
            this.HourlyWage = HourlyWage;
            AddPromotionrRequest();
        }

        private void AddPromotionrRequest()
        {
            MySqlConnection conn = Utils.GetConnection();
            int count = -1;
            try
            {
                string sqlCheck = "SELECT count(id) FROM " + tableName + " where person_id=@personId;";

                MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@personId", PersonId);
                conn.Open();

                Object result = cmdCheck.ExecuteScalar();
                if (result != null) { count = Convert.ToInt32(result); }

                if (count == 0)
                {
                    string sql = "INSERT INTO " + tableName + " (person_id, created_by_id, hourly_wage) VALUES (@person_id, @created_by_id, @hourly_wage);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@person_id", PersonId);
                    cmd.Parameters.AddWithValue("@created_by_id", CreatedById);
                    cmd.Parameters.AddWithValue("@hourly_wage", HourlyWage);
                    int effectedRows = cmd.ExecuteNonQuery();
                    PrExists = true;
                }
                else
                {
                    PrExists = false;
                }
            }
            catch (Exception ex)
            {
                string epra = ex.Message;
                PrExists = false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<PromotionRequests> GetAllPromotionRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<PromotionRequests> promotionRequests = new List<PromotionRequests>();
            try
            {
                string sql = "SELECT pr.person_id, pr.created_by_id, u.username, p.first_name, p.last_name, ed.department_id, pr.hourly_wage FROM promotion_requests AS pr INNER JOIN employee_details AS ed ON pr.person_id = ed.person_id INNER JOIN person AS p ON pr.person_id = p.id INNER JOIN user AS u ON pr.person_id = u.account_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    promotionRequests.Add(new PromotionRequests(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), row[2].ToString(), row[3].ToString(), row[4].ToString(), Convert.ToInt32(row[5]), Convert.ToDecimal(row[6])));
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
            return promotionRequests;
        }

        public void DeclinePromotionRequest()
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

        public void ApprovePromotionRequest()
        {

            DateTime contractStartDate = DateTime.Now.AddDays(1);
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string getHourlyWageQuery = "SELECT hourly_wage FROM employee_details where person_id=@personId";
                MySqlCommand cmdCheck = new MySqlCommand(getHourlyWageQuery, conn);
                cmdCheck.Parameters.AddWithValue("@personId", PersonId);
                conn.Open();
                Object result = cmdCheck.ExecuteScalar();

                string contractUpdateQuery = "UPDATE contract SET contract_end = @end_date, contract_status = 1, contract_hourlywage = @hourlywage  WHERE person_id = @person_id AND contract_status = 0";
                MySqlCommand contractUpdateCmd = new MySqlCommand(contractUpdateQuery, conn);
                contractUpdateCmd.Parameters.AddWithValue("@end_date", GetDateTime());
                contractUpdateCmd.Parameters.AddWithValue("@hourlywage", Convert.ToDecimal(result));
                contractUpdateCmd.Parameters.AddWithValue("@person_id", PersonId);
                contractUpdateCmd.ExecuteNonQuery();

                string createNewContractQuery = "INSERT INTO contract (person_id, contract_start,contract_status,contract_hourlywage) VALUES (@person_id, @contract_start,0,@hourlywage)";
                MySqlCommand createNewContractCmd = new MySqlCommand(createNewContractQuery, conn);
                createNewContractCmd.Parameters.AddWithValue("@person_id",PersonId);
                createNewContractCmd.Parameters.AddWithValue("@hourlywage", HourlyWage);
                createNewContractCmd.Parameters.AddWithValue("@contract_start", contractStartDate);
                createNewContractCmd.ExecuteNonQuery();

                string getContractIdQuery = "SELECT id FROM contract WHERE person_id = @person_id AND contract_status = 0";
                MySqlCommand getContractIdCmd = new MySqlCommand(getContractIdQuery, conn);
                getContractIdCmd.Parameters.AddWithValue("@person_id", PersonId);
                Object result2 = getContractIdCmd.ExecuteScalar();

                string employeeDetailsUpdateQuery = "UPDATE employee_details SET hourly_wage = @hourly_wage, contract_id = @contract_id WHERE person_id = @person_id";
                MySqlCommand employeeDetailsUpdateCmd = new MySqlCommand(employeeDetailsUpdateQuery, conn);
                employeeDetailsUpdateCmd.Parameters.AddWithValue("@contract_id", Convert.ToInt32(result2));
                employeeDetailsUpdateCmd.Parameters.AddWithValue("@hourly_wage", HourlyWage);
                employeeDetailsUpdateCmd.Parameters.AddWithValue("@person_id", PersonId);
                employeeDetailsUpdateCmd.ExecuteNonQuery();

                string sql = "DELETE From " + tableName + " WHERE person_id = @person_Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@person_Id", PersonId);
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

    }
}
