using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerLibraryTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Fibonacci_FirstValueIsZero()
        {
            var actual = ProjectEulerLibrary.Math.Fibonacci(1);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Fibonacci_TenthValueIs34()
        {
            var actual = ProjectEulerLibrary.Math.Fibonacci(10);

            Assert.AreEqual(34, actual);
        }
    }
}
