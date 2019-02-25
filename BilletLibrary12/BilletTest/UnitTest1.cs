using BilletLibrary12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BilPrisMetodeTest()
        {
            var bil = new Bil();

            double pris = bil.Pris(true);

            Assert.AreEqual(237.5, pris);
        }

        [TestMethod]
        public void BilKøretøjMetodeTest()
        {
            var bil = new Bil();

            string køretøj = bil.Køretøj();

            Assert.AreEqual("Bil", køretøj);
        }

        [TestMethod]
        public void MCPrisMetodeTest()
        {
            var mc = new MC();

            double pris = mc.Pris(false);

            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void MCKøretøjMetodeTest()
        {
            var mc = new MC();

            string køretøj = mc.Køretøj();

            Assert.AreEqual("MC", køretøj);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void NummerpladeErForMangeNummerer()
        //{
        //    var bil = new Bil();

        //    string nummerplade = bil.Nummerplade();

        //    Assert.Fail();
        //}



    }
}
