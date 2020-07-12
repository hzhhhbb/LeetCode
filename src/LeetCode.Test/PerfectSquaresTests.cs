using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class PerfectSquaresTests
    {
        [Test()]
        public void NumSquaresTest()
        {
            Assert.AreEqual(3,new PerfectSquares().NumSquares(43));
            Assert.AreEqual(3,new PerfectSquares().NumSquares(12));
            Assert.AreEqual(2,new PerfectSquares().NumSquares(13));
            Assert.AreEqual(3,new PerfectSquares().NumSquares(14));
            Assert.AreEqual(3,new PerfectSquares().NumSquares(48));
        }
    }
}