using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;

namespace RecapNedarvningTests.Tests
{
    [TestClass()]
    public class ElBilTests
    {
        [TestMethod()]
        public void RækkeViddeTest()
        {
            var elBil = new ElBil(200000, 2015, 10, 50);
            Assert.AreEqual(500, elBil.RækkeVidde());
        }

        [TestMethod()]
        public void GrønAfgiftTest()
        {
            var elBil = new ElBil(200000, 2015, 10, 50);
            Assert.AreEqual(0,elBil.GrønAfgift());
        }

        [TestMethod()]
        public void Registreringsafgift2015_kr80500Test()
        {
            var elBil = new ElBil(80500, 2015, 10, 50);
            Assert.AreEqual(16905,elBil.Registreringsafgift());
        }
        [TestMethod()]
        public void Registreringsafgift2016_kr80500Test()
        {
            var elBil = new ElBil(80500, 2016, 10, 50);
            Assert.AreEqual(16905, elBil.Registreringsafgift());
        }
        
        [TestMethod()]
        public void Registreringsafgift2015_kr81700Test()
        {
            var elBil = new ElBil(81700, 2015, 10, 50);
            Assert.AreEqual(17337, elBil.Registreringsafgift());
        }


        [TestMethod()]
        public void Registreringsafgift2016_kr81700Test()
        {
            var elBil = new ElBil(81700, 2016, 10, 50);
            Assert.AreEqual(17157, elBil.Registreringsafgift());
        }

    }
}