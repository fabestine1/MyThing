using MySql.Data.MySqlClient;
using System;

namespace MediaBazar
{
    class Utils
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi425113;Database=dbi425113;Pwd=bropro12;");
            return conn;
        }
        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
