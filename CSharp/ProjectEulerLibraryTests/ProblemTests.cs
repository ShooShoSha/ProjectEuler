namespace ProjectEulerLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class ProblemTests
    {
        [TestMethod()]
        public void SolveProblem1Test()
        {
            var actual = Problem.SolveProblem1(10);

            Assert.AreEqual(23, actual);
        }

        [TestMethod]
        public void SolveProblem2Test()
        {
            var actual = Problem.SolveProblem2();

            Assert.AreEqual(4613732, actual);
        }
    }
}