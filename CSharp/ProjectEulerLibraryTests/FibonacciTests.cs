using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerLibrary.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod]
        public void Values_ContainFirstTenFibonacciValues()
        {
            var target = new Fibonacci();
            var error = "The {0} Fibonacci value is not {1}";

            Assert.AreEqual(1, target.Values[0], string.Format(error, "1st", 1));
            Assert.AreEqual(2, target.Values[1], string.Format(error, "2nd", 2));
            Assert.AreEqual(3, target.Values[2], string.Format(error, "3rd", 2));
            Assert.AreEqual(5, target.Values[3], string.Format(error, "4th", 2));
            Assert.AreEqual(8, target.Values[4], string.Format(error, "5th", 2));
            Assert.AreEqual(13, target.Values[5], string.Format(error, "6th", 2));
            Assert.AreEqual(21, target.Values[6], string.Format(error, "7th", 2));
            Assert.AreEqual(34, target.Values[7], string.Format(error, "8th", 2));
            Assert.AreEqual(55, target.Values[8], string.Format(error, "9th", 2));
            Assert.AreEqual(89, target.Values[9], string.Format(error, "10th", 2));
        }

        [TestMethod]
        public void Values_SumOfFirstTen_Equals231()
        {
            var target = new Fibonacci();

            Assert.AreEqual(231, target.Values.Take(10).Sum());
        }

        [TestMethod]
        public void Values_SumOfEvenLessThan100_Equals44()
        {
            var target = new Fibonacci();

            Assert.AreEqual(44, target.Values.Where(n => n < 100 && n % 2 == 0).Sum());
        }
    }
}