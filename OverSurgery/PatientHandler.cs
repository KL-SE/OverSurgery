using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class PatientHandler
    {
        public int addNewPatient( MySqlConnection connection , Patient patient )
        {
            string sql              = "INSERT INTO patient(name, mykadNo, age) VALUES ('" + patient.Name + "','" + patient.Mykad + "','" + patient.Age + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}