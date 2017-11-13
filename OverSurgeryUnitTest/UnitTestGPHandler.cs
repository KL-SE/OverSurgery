using OverSurgery;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestGPHandler
    {
        [TestMethod]
        public void TestAddNewGP()
        {
            DbConnector dbC = new DbConnector();
            string response = dbC.connect();
            Assert.AreEqual( "Done" , response );

            GeneralPractitioner gp  = new GeneralPractitioner();
            gp.Name                 = "Hector Barbossa";
            gp.Status               = 1;
            gp.DateJoined           = new DateTime( 2017 , 1 , 15 , 0 , 0 , 0 );
            gp.LoginName            = "hector";
            gp.Password             = "hector123";

            GPHandler gpHandler = new GPHandler();
            int response2       = gpHandler.addNewGP( dbC.getConnection() , gp );
            Assert.IsNotNull( response2 );
        }
    }
}