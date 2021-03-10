using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaBazar
{
    public class StockRequest : Stock
    {
        public int Quantity
        {
            get;
            private set;
        }
        public StockRequest(string name, string description, int quantityInDepot, int quantityInStore, decimal price, int departmentId, int quantity) : base(name, description, quantityInDepot, quantityInStore, price, departmentId)
        {
            this.Quantity = quantity;
        }
        public StockRequest(Stock s, int quantity) : base(s.Name, s.Description, s.QuantityInDepot, s.QuantityInStore, s.Price, s.DepartmentId)
        {
            this.Quantity = quantity;
            // CreateStockRequest(); // todo: a diff method should be created but it should be similliar to that one
        }

        public static bool CreateStockRequest(int stock_id, int quantity)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO stockrequests(stock_id, needed_quantity) VALUES (@id, @quantity);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", stock_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                String e = ex.Message;
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public static List<StockRequest> GetAllShelfRestockRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<StockRequest> requests = new List<StockRequest>();
            List<Stock> stocks = new List<Stock>();
            try
            {
                string sql = "SELECT name, description, quantity_in_depo, quantity_in_store, price, department_id, needed_quantity FROM stock INNER JOIN stockrequests ON stock_id = id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    StockRequest request = new StockRequest(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2].ToString()), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), Convert.ToInt32(row[6]));
                    requests.Add(request);
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
            return requests;
        }
    }
}