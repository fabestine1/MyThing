using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace MediaBazar
{
    public class CheckInService
    {
        public void OnCheckIn(int userId)
        {
            MySqlConnection conn = Utils.GetConnection();

            int today = (int)DateTime.Today.DayOfWeek;
            int currentDay = 0;

            if (today == 0)
            {
                currentDay = 6;
            }
            else if (today == 1)
            {
                currentDay = 0;
            }
            else if (today == 2)
            {
                currentDay = 1;
            }
            else if (today == 3)
            {
                currentDay = 2;
            }
            else if (today == 4)
            {
                currentDay = 3;
            }
            else if (today == 5)
            {
                currentDay = 4;
            }
            else if (today == 6)
            {
                currentDay = 5;
            }

            List<string> workingShifts = Employee.GetEmployeeCurrentWorkingShifts(userId); 

            DateTime startOfWeek = DateTime.Today.AddDays(
            (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
            (int)DateTime.Today.DayOfWeek);

            string result = string.Join("," + Environment.NewLine, Enumerable
              .Range(0, 7)
              .Select(i => startOfWeek
                 .AddDays(i)
                 .ToString("yyyy-MM-dd")));
            var arrayCurrentWeek = result.Split(',');
            string currentMonday = arrayCurrentWeek[0];

            try
            {
                if (workingShifts.Count != 0)
                {
                    string updateShiftAttendance = "UPDATE employee_working_days SET attended = 1 WHERE employee_id=@employee_id AND week_day_id=@today AND assigned_date=@currentMonday";
                    conn.Open();
                    MySqlCommand updateShiftAttendanceCmd = new MySqlCommand(updateShiftAttendance, conn);
                    updateShiftAttendanceCmd.Parameters.AddWithValue("@employee_id", userId);
                    updateShiftAttendanceCmd.Parameters.AddWithValue("@today", currentDay);
                    updateShiftAttendanceCmd.Parameters.AddWithValue("@currentMonday", currentMonday);
                    updateShiftAttendanceCmd.ExecuteNonQuery();
                }
            }
            catch(Exception)
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
