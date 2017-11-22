using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class PrescriptionHandler
    {
        public int addNewPrescription( MySqlConnection connection , Prescription prescription )
        {
            string sql              = "INSERT INTO prescription(gp_id, patient_id, prescribed, expires) VALUES ('" + prescription.Gp.Id + "','" + prescription.Patient.Id + "','" + prescription.Prescribed.ToString("yyyy-MM-dd HH:mm:ss") + "','" + prescription.Expires.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}