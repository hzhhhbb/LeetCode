using LeetCode.StringAndArray;

using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class FindMinimumInRotatedSortedArrayTests
    {
        [Test()]
        public void FindMinTest()
        {
            int[] input = { 3, 4, 5, 1, 2 };
            int expected = 1;

            Assert.AreEqual(expected, new FindMinimumInRotatedSortedArray().FindMin(input));
        }

        [Test()]
        public void FindMinTest1()
        {
            int[] input = { 4, 5, 6, 7, 0, 1, 2 };
            int expected = 0;

            Assert.AreEqual(expected, new FindMinimumInRotatedSortedArray().FindMin(input));
        }

        [Test()]
        public void FindMinTest2()
        {
            int[] input = { 1 };
            int expected = 1;

            Assert.AreEqual(expected, new FindMinimumInRotatedSortedArray().FindMin(input));
        }

        [Test()]
        public void FindMinTest3()
        {
            int[] input = { 3, 1, 2 };
            int expected = 1;

            Assert.AreEqual(expected, new FindMinimumInRotatedSortedArray().FindMin(input));
        }

        [Test()]
        public void FindMinTest4()
        {
            int[] input = { 3, 1, 2, 4 };
            int expected = 1;

            Assert.AreEqual(expected, new FindMinimumInRotatedSortedArray().FindMin(input));
        }
    }
}