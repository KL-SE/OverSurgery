using OverSurgery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestTestResultHandler
    {
        [TestMethod]
        public void TestAddNewTestResult()
        {
            DbConnector dbC = new DbConnector();
            string response = dbC.connect();
            Assert.AreEqual( "Done" , response );

            Patient patient = new Patient();
            patient.Name    = "Jack Sparrow";
            patient.Age     = 23;
            patient.Mykad   = "123456789012";
            
            GeneralPractitioner gp  = new GeneralPractitioner();
            gp.Name                 = "Hector Barbossa";
            gp.Status               = 1;
            gp.DateJoined           = new DateTime( 2017 , 1 , 15 , 0 , 0 , 0 );
            gp.LoginName            = "hector";
            gp.Password             = "hector123";

            TestResult testResult   = new TestResult();
            testResult.Gp           = gp;
            testResult.Patient      = patient;
            testResult.Title        = "Example Test";
            testResult.Description  = "Example Description";
            testResult.Result       = "Example Result";
            testResult.Remark       = "Example Remark";

            TestResultHandler handler   = new TestResultHandler();
            int response2               = handler.addNewTestResult( dbC.getConnection() , testResult );
            Assert.IsNotNull( response2 );
        }
    }
}