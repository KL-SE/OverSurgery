using OverSurgery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestMedicationHandler
    {
        [TestMethod]
        public void TestAddNewMedication()
        {
            DbConnector dbC = new DbConnector();
            string response = dbC.connect();
            Assert.AreEqual( "Done" , response );

            Medication medication   = new Medication();
            medication.Code         = "MED001";
            medication.Name         = "Example Medication";
            medication.Description  = "Example Description";

            MedicationHandler handler   = new MedicationHandler();
            int response2               = handler.addNewMedication( dbC.getConnection() , medication );
            Assert.IsNotNull( response2 );
        }
    }
}