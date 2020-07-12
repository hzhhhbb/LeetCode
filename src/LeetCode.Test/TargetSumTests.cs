using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class TargetSumTests
    {
        [Test()]
        public void FindTargetSumWaysTest()
        {
            int[] nums={1, 1, 1, 1, 1};
            Assert.AreEqual(5,new TargetSum().FindTargetSumWays(nums,3));
        }
    }
}