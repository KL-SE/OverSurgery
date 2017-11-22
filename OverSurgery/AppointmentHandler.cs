using MySql.Data.MySqlClient;
using System;

namespace OverSurgery
{
    public class AppointmentHandler
    {
        public int addNewAppointment( MySqlConnection connection , Appointment appointment )
        {
            string sql              = "INSERT INTO appointment(time, gp_id, patient_id, cancelled) VALUES ('" + appointment.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "','" + appointment.Gp.Id + "','" + appointment.Patient.Id + "','" + ( appointment.Cancelled ? 1 : 0 ) + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}