using System;
using System.Data.SqlClient;
using System.Configuration;

namespace HotelBookingApplication.DAL
{
    class DBSQLServerUtil
    {
        public static SqlConnection GetDBConnection(string connectionString)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
            }
            catch (Exception exCon)
            {
                Console.WriteLine("Unable to connect to database: {0}", exCon);
                return null;
            }
        }
    }
    public class Connection
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            return DBSQLServerUtil.GetDBConnection(connectionString);
        }
    }
}
