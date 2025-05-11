using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDFinal;



namespace TDDFinal.Tests
{
    [TestClass]
    public class AverageHelperTests
    {
        // ✅ PASS: Correct average
        [TestMethod]
        public void CalculateAverageYear_ReturnsCorrectAverage()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "ModelA", "MakeA", 2010, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2020, "Truck", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2015, avg);
        }

        // ❌ FAIL: Intentionally wrong expected value
        [TestMethod]
        public void CalculateAverageYear_ShouldFail_WhenExpectedIsWrong()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "ModelA", "MakeA", 2010, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2020, "Truck", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2020, avg); // Wrong on purpose
        }

        // ✅ PASS: Empty list returns 0
        [TestMethod]
        public void CalculateAverageYear_EmptyList_ReturnsZero()
        {
            var vehicles = new List<Vehicle>();
            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(0, avg);
        }

        // ✅ PASS: All same year returns that year
        [TestMethod]
        public void CalculateAverageYear_AllSameYear_ReturnsThatYear()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "A", "B", 2015, "Bus", "OK"),
                new Vehicle("2", "C", "D", 2015, "Truck", "OK"),
                new Vehicle("3", "E", "F", 2015, "Private", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2015, avg);
        }
    }
}
