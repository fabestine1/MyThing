using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MediaBazar
{
    public class Stock
    {
        private const string tableName = "stock";
        public int Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
        public string Description
        {
            get;
            private set;
        }

        public int QuantityInDepot
        {
            get;
            private set;
        }

        public int QuantityInStore
        {
            get;
            private set;
        }

        public int DepartmentId
        {
            get;
            private set;
        }

        public decimal Price
        {
            get;
            private set;
        }

        public Stock(string name, string description, int quantityInDepot, int quantityInStore, decimal price, int departmentId)
        {
            this.Name = name;
            this.Description = description;
            this.QuantityInDepot = quantityInDepot;
            this.QuantityInStore = quantityInStore;
            this.Price = price;
            this.DepartmentId = departmentId;
            AddStock();
        }

        public static void EditStock(int stockId, string name, decimal price, decimal storeQ, decimal depoQ)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "UPDATE " + tableName + " SET name = @name, price = @price, quantity_in_store = @quantity_in_store, quantity_in_depo = @quantity_in_depo WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity_in_store", storeQ);
                cmd.Parameters.AddWithValue("@quantity_in_depo", depoQ);
                cmd.Parameters.AddWithValue("@id", stockId);

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

        public Stock(bool skipDb, string name, string description, int quantityInDepot, int quantityInStore, decimal price, int departmentId)
        {
            this.Name = name;
            this.Description = description;
            this.QuantityInDepot = quantityInDepot;
            this.QuantityInStore = quantityInStore;
            this.Price = price;
            this.DepartmentId = departmentId;
        }

        private void AddStock()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO stock(name, description, department_id, quantity_in_depo, quantity_in_store, price, currency_id) VALUES (@name, @description, @department_id, @depo, @store, @price, 1);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@description", Description);
                cmd.Parameters.AddWithValue("@department_id", DepartmentId);
                cmd.Parameters.AddWithValue("@depo", QuantityInDepot);
                cmd.Parameters.AddWithValue("@store", QuantityInStore);
                cmd.Parameters.AddWithValue("@price", Price);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                Id = (int)cmd.LastInsertedId;
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

        public static List<Stock> GetAllStocks()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Stock> stocks = new List<Stock>();
            try
            {
                string sql = "SELECT name, description,quantity_in_depo,quantity_in_store, price,department_id,id FROM stock;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    string name = !String.IsNullOrWhiteSpace(row[0].ToString()) ? row[0].ToString() : "-";
                    string descr = !String.IsNullOrWhiteSpace(row[1].ToString()) ? row[1].ToString() : "-";
                    int depo = Convert.ToInt32(row[2]);
                    int store = Convert.ToInt32(row[3]);
                    int price = Convert.ToInt32(row[4]);
                    int department = Convert.ToInt32(row[5]);
                    Stock s = new Stock(true, name, descr, depo, store, price, department);
                    s.Id = Convert.ToInt32(row[6]);
                    stocks.Add(s);
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
            return stocks;
        }

        private static string BuildFilterQuery(int departmentId = -1, string productName = null)
        {
            string fields = "name, description, quantity_in_depo, quantity_in_store, price, department_id, id";
            string whereClause = "";

            if (departmentId != -1 || productName != null)
            {
                int count = 0;
                whereClause = "WHERE ";
                // TODO: this is not secure, find a way to fix it later
                if (departmentId != -1)
                {
                    count++;
                    whereClause += "department_id = " + departmentId;
                }
                if (productName != null)
                {
                    if (count != 0) whereClause += " AND ";
                    whereClause += "name LIKE '%" + productName + "%'";
                }
            }
            return "SELECT " + fields + " FROM stock " + whereClause + ';';
        }
        public static List<Stock> FilterStocks(int departmentId = -1, string productName = null)
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Stock> stocks = new List<Stock>();
            try
            {
                String sql = BuildFilterQuery(departmentId, productName);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    string name = !String.IsNullOrWhiteSpace(row[0].ToString()) ? row[0].ToString() : "-";
                    string descr = !String.IsNullOrWhiteSpace(row[1].ToString()) ? row[1].ToString() : "-";
                    int depo = Convert.ToInt32(row[2]);
                    int store = Convert.ToInt32(row[3]);
                    int price = Convert.ToInt32(row[4]);
                    int department = Convert.ToInt32(row[5]);

                    Stock s = new Stock(true, name, descr, depo, store, price, department);
                    s.Id = Convert.ToInt32(row[6]);
                    stocks.Add(s);
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
            return stocks;
        }

        public static Stock GetStockById(int id)
        {
            MySqlConnection conn = Utils.GetConnection();
            Stock s = null;
            try
            {
                string sql = "SELECT name, description,quantity_in_depo,quantity_in_store, price,department_id FROM stock WHERE id=@id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    string name = !String.IsNullOrWhiteSpace(row[0].ToString()) ? row[0].ToString() : "-";
                    string descr = !String.IsNullOrWhiteSpace(row[1].ToString()) ? row[1].ToString() : "-";
                    int depo = Convert.ToInt32(row[2]);
                    int store = Convert.ToInt32(row[3]);
                    int price = Convert.ToInt32(row[4]);
                    int department = Convert.ToInt32(row[5]);
                    s = new Stock(true, name, descr, depo, store, price, department);
                    s.Id = Convert.ToInt32(row[6]);
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
            return s;

        }
        public static void Remove(int id)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE FROM stock WHERE id=@id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
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

        public int GetTotalQuantity()
        {
            return QuantityInStore + QuantityInDepot;
        }
    }
}