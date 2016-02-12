using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;

namespace RecapNedarvningTests.Tests
{
    /// <summary>
    /// Her testes de metoder som ikke bliver override i alle de specialiserede klasser
    /// </summary>
    [TestClass()]
    public class BilTests
    {

        [TestMethod()]
        public void Registreringsafgift2015_kr80500Test()
        {
            var testbil = new Dieselbil(80500, 2015, 20, 30);
            Assert.AreEqual(84525, testbil.Registreringsafgift());
        }

        [TestMethod()]
        public void Registreringsafgift2016_kr81700Test()
        {
            var testbil = new Dieselbil(81700, 2016, 20, 30);
            Assert.AreEqual(85785, testbil.Registreringsafgift());
        }

        [TestMethod()]
        public void Registreringsafgift2016_kr80500Test()
        {
            var testbil = new Dieselbil(80500, 2016, 20, 30);
            Assert.AreEqual(84525, testbil.Registreringsafgift());
        }

        [TestMethod()]
        public void Registreringsafgift2016_kr200000Test()
        {
            var testbil = new Dieselbil(200000, 2016, 20, 30);
            Assert.AreEqual(298725, testbil.Registreringsafgift());
        }


        [TestMethod()]
        public void Registreringsafgift2015_kr200000Test()
        {
            var testbil = new Dieselbil(200000, 2015, 20, 30);
            Assert.AreEqual(299625, testbil.Registreringsafgift());
        }

        /// <summary>
        /// tester at der bliver kastet en argumentexception hvis året er mindre end 2014
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Registreringsafgift2013_kr200000Test()
        {
            var testbil = new Dieselbil(200000, 2013, 20, 30);
            Assert.AreEqual(299625, testbil.Registreringsafgift());
        }

        /// <summary>
        /// tester at der IKKE bliver kastet en argumentexception i året 2014
        /// </summary>
        [TestMethod()]
        public void Registreringsafgift2014_kr200000Test()
        {
            var testbil = new Dieselbil(200000, 2014, 20, 30);
            Assert.AreEqual(299625, testbil.Registreringsafgift());
        }

        /// <summary>
        /// tester at der bliver kastet en argumentexception hvis prisen er 0 kr.        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Registreringsafgift2014_kr0Test()
        {
            var testbil = new Dieselbil(0, 2014, 20, 30);
            Assert.AreEqual(0, testbil.Registreringsafgift());
        }


        /// <summary>
        /// tester at der bliver kastet en argumentexception hvis prisen er mindre end 0 kr.       
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Registreringsafgift2014_krminusTest()
        {
            var testbil = new Dieselbil(-20000, 2014, 20, 30);
            Assert.AreEqual(0, testbil.Registreringsafgift());
        }
    }
}