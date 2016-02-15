using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;

namespace RecapNedarvningTests.Tests
{
    [TestClass()]
    public class DieselbilTests
    {

        [TestInitialize]
        public void Init()
        {
            
        }

        [TestMethod()]
        public void DieselbilTest()
        {
           var testbil = new Dieselbil(80500, 2015, 20, 30);
            Assert.AreEqual(84525,testbil.Registreringsafgift());
        }
       
        //[TestMethod()]
        //public void GrønAfgiftTest()
        //{
        //    var testbil = new Dieselbil(100500, 2016, 20, 30);
        //    Assert.AreEqual(3000,testbil.GrønAfgift());
        //}

        [TestMethod()]
        public void RækkeViddeTest()
        {
            var testbil = new Dieselbil(100500, 2016, 20, 30);
            Assert.AreEqual(600, testbil.RækkeVidde());
        }

        /// <summary>
        /// tester at der bliver kastet en exception hvis under 5 km/l med partikelfilter
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(GrønAfgiftException))]
        public void TestDieselBil_mindreEnd5KMprL_GrønAfgift()
        {
            var bil = new Dieselbil(80500, 2015, 4, 30);
            bil.GrønAfgift();
            //Assert.AreEqual(bil.GrønAfgift());
        }

        /// <summary>
        /// tester grøn afgift >=5 til =15 km pr l
        /// </summary>
        [TestMethod]
        public void TestDieselBil_5_til_15KMprL_GrønAfgift()
        {
            var bil5 = new Dieselbil(100500, 2015, 5, 30);
            var bil15 = new Dieselbil(100500, 2015, 15, 30);

            Assert.AreEqual(bil5.GrønAfgift(), 8000);
            Assert.AreEqual(bil15.GrønAfgift(), 8000);
        }

        /// <summary>
        /// tester grøn afgift >15 til =25 km pr l
        /// </summary>
        [TestMethod]
        public void TestDieselBil_15_til_25KMprL_GrønAfgift()
        {
            var bil16 = new Dieselbil(100500, 2015, 16, 30);
            var bil15 = new Dieselbil(100500, 2015, 15, 30);
            var bil25 = new Dieselbil(100500, 2015, 25, 30);

            Assert.AreEqual(bil15.GrønAfgift(), 8000); //tester grænsen
            Assert.AreEqual(bil16.GrønAfgift(), 4000);
            Assert.AreEqual(bil25.GrønAfgift(), 4000);
        }

        /// <summary>
        /// tester grøn afgift >15 til =25 km pr l
        /// </summary>
        [TestMethod]
        public void TestDieselBil_størrerEnd25KMprL_GrønAfgift()
        {
            var bil25 = new Dieselbil(100500, 2015, 25, 30);
            var bil26 = new Dieselbil(100500, 2015, 26, 30);
            var bil100 = new Dieselbil(100500, 2015, 100, 12);

            Assert.AreEqual(bil25.GrønAfgift(), 4000);//tester grænsen
            Assert.AreEqual(bil26.GrønAfgift(), 1500);
            Assert.AreEqual(bil100.GrønAfgift(), 1500);
        }

        #region GrønAfgift uden PartikelFilter
        /// <summary>
        /// tester at der bliver kastet en exception hvis under 5 km/l med partikelfilter
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(GrønAfgiftException))]
        public void TestDieselBil_mindreEnd5KMprL_IngenPartikelfilter_GrønAfgift()
        {
            var bil = new Dieselbil(80500, 2015, 4, 30, false);
            Assert.AreEqual(bil.GrønAfgift(), 0);
        }

        /// <summary>
        /// tester grøn afgift >=5 til =15 km pr l _IngenPartikelfilter_
        /// </summary>
        [TestMethod]
        public void TestDieselBil_5_til_15KMprL_IngenPartikelfilter_GrønAfgift()
        {
            var bil5 = new Dieselbil(100500, 2015, 5, 30, false);
            var bil15 = new Dieselbil(100500, 2015, 15, 30, false);

            Assert.AreEqual(bil5.GrønAfgift(), 9000);
            Assert.AreEqual(bil15.GrønAfgift(), 9000);
        }

        /// <summary>
        /// tester grøn afgift >15 til =25 km pr l
        /// </summary>
        [TestMethod]
        public void TestDieselBil_15_til_25KMprL_IngenPartikelfilter_GrønAfgift()
        {
            var bil16 = new Dieselbil(100500, 2015, 16, 30, false);
            var bil15 = new Dieselbil(100500, 2015, 15, 30, false);
            var bil25 = new Dieselbil(100500, 2015, 25, 30, false);

            Assert.AreEqual(bil15.GrønAfgift(), 9000); //tester grænsen
            Assert.AreEqual(bil16.GrønAfgift(), 5000);
            Assert.AreEqual(bil25.GrønAfgift(), 5000);
        }

        /// <summary>
        /// tester grøn afgift >15 til =25 km pr l
        /// </summary>
        [TestMethod]
        public void TestDieselBil_størrerEnd25KMprL_IngenPartikelfilter_GrønAfgift()
        {
            var bil25 = new Dieselbil(100500, 2015, 25, 30,false);
            var bil26 = new Dieselbil(100500, 2015, 26, 30, false);
            var bil100 = new Dieselbil(100500, 2015, 100, 12, false);

            Assert.AreEqual(bil25.GrønAfgift(), 5000);//tester grænsen
            Assert.AreEqual(bil26.GrønAfgift(), 2500);
            Assert.AreEqual(bil100.GrønAfgift(), 2500);
        }
        #endregion  

    }
}