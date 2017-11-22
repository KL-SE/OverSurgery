using OverSurgery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestAppointmentHandler
    {
        [TestMethod]
        public void TestAddNewAppointment()
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

            Appointment appointment = new Appointment();
            appointment.Gp          = gp;
            appointment.Patient     = patient;
            appointment.DateTime    = new DateTime( 2017 , 1 , 15 , 0 , 0 , 0 );
            appointment.Cancelled   = false;

            AppointmentHandler handler  = new AppointmentHandler();
            int response2               = handler.addNewAppointment( dbC.getConnection() , appointment );
            Assert.IsNotNull( response2 );
        }
    }
}