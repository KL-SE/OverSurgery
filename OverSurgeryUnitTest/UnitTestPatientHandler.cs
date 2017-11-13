using OverSurgery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestPatientHandler
    {
        [TestMethod]
        public void TestAddNewPatient()
        {
            DbConnector dbC = new DbConnector();
            string response = dbC.connect();
            Assert.AreEqual( "Done" , response );

            Patient patient = new Patient();
            patient.Name    = "Jack Sparrow";
            patient.Age     = 23;
            patient.Mykad   = "123456789012";

            PatientHandler pHandler = new PatientHandler();
            int response2           = pHandler.addNewPatient( dbC.getConnection() , patient );
            Assert.IsNotNull( response2 );
        }
    }
}