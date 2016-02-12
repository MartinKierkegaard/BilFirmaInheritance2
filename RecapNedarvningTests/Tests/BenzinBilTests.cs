using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;

namespace RecapNedarvningTests.Tests
{
    /// <summary>
    /// Test af Benzinbiler
    /// </summary>
    [TestClass()]
    public class BenzinBilTests
    {
        /// <summary>
        /// Test at røkkevidden bliver regnet rigtigt ud
        /// </summary>
        [TestMethod()]
        public void RækkeViddeTest()
         {
            var testbil = new BenzinBil(30000, 2016, 15, 40);
            Assert.AreEqual(600,testbil.RækkeVidde());
        }

        /// <summary>
        /// Test at der bliver kastet en ArgumentException hvis KmPrL er negativ
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RækkeViddeNegativKmprLTest()
        {
            var testbil = new BenzinBil(30000, 2016, 15, -40);
            Assert.AreEqual(-600, testbil.RækkeVidde());
        }

        /// <summary>
        /// Test at der bliver kastet en ArgumentException hvis tank er negativ
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RækkeViddeNegativTankTest()
        {
            var testbil = new BenzinBil(30000, 2016, -15, 40);
            Assert.AreEqual(-600, testbil.RækkeVidde());
        }


        /// <summary>
        /// Test at der bliver kastet en ArgumentException hvis KmPrL er 0
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RækkeViddeNulKmprLTest()
        {
            var testbil = new BenzinBil(30000, 2016, 15, 0);
            Assert.AreEqual(0, testbil.RækkeVidde());
        }


        /// <summary>
        /// Test at der bliver kastet en ArgumentException hvis tank er 0
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RækkeViddeNulTankTest()
        {
            var testbil = new BenzinBil(30000, 2016, 15, 0);
            Assert.AreEqual(0, testbil.RækkeVidde());
        }

        /// <summary>
        /// Test at den grønneafgift udregens rigtigt
        /// </summary>
        [TestMethod()]
        public void GrønAfgiftTest()
        {
            var testBil = new BenzinBil(400000, 2016, 11, 50);
            Assert.AreEqual(1500,testBil.GrønAfgift());
        }
    }
}