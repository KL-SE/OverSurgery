using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class ReceptionistHandler
    {
        public int addNewReceptionist( MySqlConnection connection , Receptionist receptionist )
        {
            string sql              = "INSERT INTO receptionist(name, status, date_joined, login_name, password) VALUES ('" + receptionist.Name + "','" + receptionist.Status + "','" + receptionist.DateJoined.ToString("yyyy-MM-dd HH:mm:ss") + "','" + receptionist.LoginName + "','" + receptionist.Password + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}