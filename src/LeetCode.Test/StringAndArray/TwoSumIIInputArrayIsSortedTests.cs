using LeetCode.StringAndArray;

using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class TwoSumIIInputArrayIsSortedTests
    {
        [Test()]
        public void TwoSumTest()
        {
            int[] input = { 2, 7, 11, 15 };
            int target = 9;

            int[] expected = { 1, 2 };

            Assert.AreEqual(expected, new TwoSumIIInputArrayIsSorted().TwoSum(input, target));
        }

        [Test()]
        public void TwoSumTest1()
        {
            int[] input = { 2, 7, 11, 15, 30 };
            int target = 37;

            int[] expected = { 2, 5 };

            Assert.AreEqual(expected, new TwoSumIIInputArrayIsSorted().TwoSum(input, target));
        }

        [Test()]
        public void TwoSumTest2()
        {
            int[] input = { -1, 0 };
            int target = -1;

            int[] expected = { 1, 2 };

            Assert.AreEqual(expected, new TwoSumIIInputArrayIsSorted().TwoSum(input, target));
        }
    }
}