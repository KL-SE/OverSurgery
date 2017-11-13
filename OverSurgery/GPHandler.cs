using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class GPHandler
    {
        public int addNewGP( MySqlConnection connection , GeneralPractitioner gp )
        {
            string sql              = "INSERT INTO gp(name, status, date_joined, login_name, password) VALUES ('" + gp.Name + "','" + gp.Status + "','" + gp.DateJoined.ToString("yyyy-MM-dd HH:mm:ss") + "','" + gp.LoginName + "','" + gp.Password + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}