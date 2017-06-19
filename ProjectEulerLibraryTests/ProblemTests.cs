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
    }
}