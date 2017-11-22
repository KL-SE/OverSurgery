using MySql.Data.MySqlClient;

namespace OverSurgery
{
    public class TestResultHandler
    {
        public int addNewTestResult( MySqlConnection connection , TestResult testResult )
        {
            string sql              = "INSERT INTO test_result(gp_id, patient_id, title, description, result, remark) VALUES ('" + testResult.Gp.Id + "','" + testResult.Patient.Id + "','" + testResult.Title + "','" + testResult.Description + "','" + testResult.Result + "','" + testResult.Remark + "');";
            MySqlCommand command    = new MySqlCommand( sql , connection );

            return command.ExecuteNonQuery();
        }
    }
}