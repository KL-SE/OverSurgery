using OverSurgery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestReceptionisttHandler
    {
        [TestMethod]
        public void TestAddNewReceptionist()
        {
            DbConnector dbC = new DbConnector();
            string response = dbC.connect();
            Assert.AreEqual( "Done" , response );
            
            Receptionist receptionist   = new Receptionist();
            receptionist.Name           = "Hector Barbossa";
            receptionist.Status         = 1;
            receptionist.DateJoined     = new DateTime( 2017 , 1 , 15 , 0 , 0 , 0 );
            receptionist.LoginName      = "hector";
            receptionist.Password       = "hector123";

            ReceptionistHandler handler = new ReceptionistHandler();
            int response2               = handler.addNewReceptionist( dbC.getConnection() , receptionist );
            Assert.IsNotNull( response2 );
        }
    }
}