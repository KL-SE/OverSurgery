using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class MedicationHandler
    {
        public int addNewMedication( MySqlConnection connection , Medication medication )
        {
            string sql              = "INSERT INTO medication(code, name, description) VALUES ('" + medication.Code + "','" + medication.Name + "','" + medication.Description + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}