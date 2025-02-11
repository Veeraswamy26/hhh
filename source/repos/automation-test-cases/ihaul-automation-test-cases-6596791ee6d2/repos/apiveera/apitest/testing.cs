using apiveera;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace apitest
{
    [TestClass]
    public class testing
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Apitest1 = new veera();
            var response = Apitest1.Getdetails();
            Assert.AreEqual("Veera", response.Data[0].firstName);
            Console.WriteLine("get user api is succesful");
                }
    }
}
