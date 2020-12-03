using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VedioRental;

namespace UnitTesting_vedioRental
{
    [TestClass]
    public class vedioRental_UnitTest
    {
        ClassDatabase Obj_Data = new ClassDatabase();

//code is to check valid Test Case of connection String
        [TestMethod]
        public void Test_ConnectionSring()
        {
            string Connection = Obj_Data.ConnString;
            Assert.AreEqual(@"Data Source=LAPTOP-II78TMAS\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True", Connection);
        }


//code is to check valid Test Case of connection String
        [TestMethod]
        public void Test_deleteMovie()
        {
            string Message = Obj_Data.MovieDelete();
            Assert.AreEqual("Movies Details are filled completely", Message);
        }
    }
}
