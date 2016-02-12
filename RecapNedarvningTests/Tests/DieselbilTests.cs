using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;

namespace RecapNedarvningTests.Tests
{
    [TestClass()]
    public class DieselbilTests
    {
        [TestMethod()]
        public void DieselbilTest()
        {
           var testbil = new Dieselbil(80500, 2015, 20, 30);

            Assert.AreEqual(84525,testbil.Registreringsafgift());
        }
       
        [TestMethod()]
        public void GrønAfgiftTest()
        {
            var testbil = new Dieselbil(100500, 2016, 20, 30);
            Assert.AreEqual(3000,testbil.GrønAfgift());
        }

        [TestMethod()]
        public void RækkeViddeTest()
        {
            var testbil = new Dieselbil(100500, 2016, 20, 30);
            Assert.AreEqual(600, testbil.RækkeVidde());
        }
    }
}