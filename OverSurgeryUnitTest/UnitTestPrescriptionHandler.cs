using OverSurgery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestPrescriptionHandler
    {
        [TestMethod]
        public void TestAddNewPrescription()
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

            Prescription prescription   = new Prescription();
            prescription.Gp             = gp;
            prescription.Patient        = patient;
            prescription.Prescribed     = new DateTime( 2017 , 1 , 15 , 0 , 0 , 0 );
            prescription.Expires        = new DateTime( 2017 , 1 , 30 , 0 , 0 , 0 );
            prescription.Medications    = new List<Medication>();

            PrescriptionHandler handler = new PrescriptionHandler();
            int response2               = handler.addNewPrescription( dbC.getConnection() , prescription );
            Assert.IsNotNull( response2 );
        }
    }
}