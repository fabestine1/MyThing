using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;

namespace MediaBazar
{
    class Export
    {
        public static void StockRequestsToExcel(string filename = "stockRequests.xlsx")
        {
            string sheetName = "StockRequests";
            List<StockRequest> requests = StockRequest.GetAllShelfRestockRequests();
            var workbook = new XLWorkbook();
            workbook.AddWorksheet(sheetName);
            var ws = workbook.Worksheet(sheetName);

            int row = 1;

            ws.Cell("A" + row.ToString()).Value = "Name";
            ws.Cell("B" + row.ToString()).Value = "Description";
            ws.Cell("C" + row.ToString()).Value = "Quantity";
            ws.Cell("D" + row.ToString()).Value = "QuantityInDepot";
            ws.Cell("E" + row.ToString()).Value = "QuantityInStore";
            row++;

            foreach (StockRequest item in requests)
            {
                ws.Cell("A" + row.ToString()).Value = item.Name;
                ws.Cell("B" + row.ToString()).Value = item.Description;
                ws.Cell("C" + row.ToString()).Value = item.Quantity;
                ws.Cell("D" + row.ToString()).Value = item.QuantityInDepot;
                ws.Cell("E" + row.ToString()).Value = item.QuantityInStore;
                row++;
            }

            workbook.SaveAs(filename);
        }

        public static void StockRequestsToCSV(string filename = "stocks.csv")
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = "SELECT name, description, needed_quantity FROM stock INNER JOIN stockrequests ON stock_id = id;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            StreamWriter sw = new StreamWriter(filename);
            object[] output = new object[reader.FieldCount];

            for (int i = 0; i < reader.FieldCount; i++)
                output[i] = reader.GetName(i);

            sw.WriteLine(string.Join(", ", output));

            while (reader.Read())
            {
                reader.GetValues(output);
                sw.WriteLine(string.Join(",", output));
            }

            sw.Close();
            reader.Close();
            conn.Close();
        }
    }
}
