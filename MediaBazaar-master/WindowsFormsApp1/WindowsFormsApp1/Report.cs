using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazar
{
    public class Report
    {
        public int ReportId { get; private set; }
        public string ReportSubject { get; private set; }
        public string ReportMessage { get; private set; }
        public string ReportStatus { get; private set; }

        public Report(int reportId, string reportSubject, string reportMessage, string reportStatus)
        {
            this.ReportId = reportId;
            this.ReportSubject = reportSubject;
            this.ReportMessage = reportMessage;
            this.ReportStatus = reportStatus;
        }

        public void MarkAsRead(int reportId)
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                string markAsReadQuery = "UPDATE reports SET status = @status WHERE id=@reportId";
                MySqlCommand markAsReadCmd = new MySqlCommand(markAsReadQuery, conn);
                markAsReadCmd.Parameters.AddWithValue("@status", "read");
                markAsReadCmd.Parameters.AddWithValue("@reportId", reportId);
                conn.Open();
                markAsReadCmd.ExecuteNonQuery();
            }
            catch
            {
                // TODO: add to error log in the future
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Report> GetAllReports()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Report> reports = new List<Report>();
            try
            {
                string getReportsQuery = "SELECT * FROM reports";
                MySqlCommand getReportsCmd = new MySqlCommand(getReportsQuery, conn);
                conn.Open();
                MySqlDataReader row = getReportsCmd.ExecuteReader();

                while (row.Read())
                {
                    reports.Add(new Report(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString()));
                }
            }
            catch
            {
                // TODO: add to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return reports;
        }
    }
}
