using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStuff;

namespace SunshineMeasurementTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            Assert.AreEqual("Eindhoven", sm.Cityname);
        }

        [TestMethod]
        public void TestAdding1DaysOfSunshine()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            sm.addSunshineOfLastDay(100);

            Assert.AreEqual("Eindhoven", sm.Cityname);
            Assert.AreEqual(100, sm.getAverageSunshine());
        }

        [TestMethod]
        public void TestAdding2DaysOfSunshine()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            sm.addSunshineOfLastDay(100);
            sm.addSunshineOfLastDay(200);

            Assert.AreEqual("Eindhoven", sm.Cityname);
            Assert.AreEqual(150, sm.getAverageSunshine());
        }

        [TestMethod]
        public void TestAddingManyDaysOfSunshine()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            sm.addSunshineOfLastDay(10);
            sm.addSunshineOfLastDay(10);
            sm.addSunshineOfLastDay(10);

            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(200);

            Assert.AreEqual("Eindhoven", sm.Cityname);
            Assert.AreEqual(200, sm.getAverageSunshine());
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestAdding0DaysOfSunshine()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            int bla = sm.getAverageSunshine();  // Now an exception should be thrown since a division by zero must happen.
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNoMaximumSunshine()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            int bla = sm.getMaximumSunshine();  // Now an exception should be thrown since there are no sunshines added.
        }
        [TestMethod]
        public void TestAdding1MaximumSunshines()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            sm.addSunshineOfLastDay(100);

            Assert.AreEqual("Eindhoven", sm.Cityname);
            Assert.AreEqual(100, sm.getMaximumSunshine());
        }

        [TestMethod]
        public void TestAdding2MaximumSunshines()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(300);

            Assert.AreEqual("Eindhoven", sm.Cityname);
            Assert.AreEqual(300, sm.getMaximumSunshine());
        }

        [TestMethod]
        public void TestAddingManyMaximumSunshines()
        {
            SunshineMeasurement sm;
            sm = new SunshineMeasurement("Eindhoven");

            sm.addSunshineOfLastDay(10);
            sm.addSunshineOfLastDay(10);
            sm.addSunshineOfLastDay(10);

            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(400);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(210);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(300);
            sm.addSunshineOfLastDay(300);
            sm.addSunshineOfLastDay(500);
            sm.addSunshineOfLastDay(200);
            sm.addSunshineOfLastDay(100);

            Assert.AreEqual("Eindhoven", sm.Cityname);
            Assert.AreEqual(500, sm.getMaximumSunshine());
        }
    }
}
