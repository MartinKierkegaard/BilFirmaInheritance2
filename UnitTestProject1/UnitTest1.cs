using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        //private ElBil bil;

        //[TestInitialize]
        //public void Before()
        //{
        //    bil = new ElBil(80500,2015,20,30);
        //}

        /// <summary>
        /// tester at grønafgift beregnes rigtigt for ElBil 
        /// </summary>
        [TestMethod]
        public void TestElBilGrønAfgift()
        {
            ElBil bil = new ElBil(80500, 2015, 20, 30);
            Assert.AreEqual(bil.GrønAfgift(), 0);
        }
        //[TestMethod]
        //public void TestDieselBilGrønAfgift()
        //{
        //    var bil = new Dieselbil(80500, 2015, 20, 30);
        //    Assert.AreEqual(bil.GrønAfgift(), 3000);
        //}

        /// <summary>
        /// tester at der bliver kstet en exception hvis under 5 km/l
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDieselBil_mindreEnd5KMprL_GrønAfgift()
        {
            var bil = new Dieselbil(80500, 2015, 4, 30);
            Assert.AreEqual(bil.GrønAfgift(), 3000);
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


        /// <summary>
        /// Tester at Argumentexception bliver kaldt hvis købsår er 2013
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestElBilKøbsår()
        {
            ElBil bil = new ElBil(80500, 2013, 20, 30);
            Assert.AreEqual(bil.Registreringsafgift(), 0);



        }

    }
}
