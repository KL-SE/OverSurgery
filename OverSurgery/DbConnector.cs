using System;
using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class DbConnector
    {
        public static string DATABASE_ADDRESS       = "localhost";
        public static uint DATABASE_PORT            = 3306;
        public static MySqlConnection connection    = null;

        public string connect()
        {
            MySqlConnectionStringBuilder sqlBuilder = new MySqlConnectionStringBuilder();
            sqlBuilder.Database                     = "oversurgerydb";
            sqlBuilder.Server                       = DATABASE_ADDRESS;
            sqlBuilder.Port                         = DATABASE_PORT;
            sqlBuilder.UserID                       = "dbcli";
            sqlBuilder.Password                     = "dbcli123";
            
            try
            {
                connection = new MySqlConnection( sqlBuilder.ConnectionString );
                connection.Open();
                return "Done";
            }
            catch( Exception e )
            {
                connection = null;
                return e.ToString();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}