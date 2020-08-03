using LeetCode.StringAndArray;

using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class ArrayPartitionITests
    {
        [Test()]
        public void ArrayPairSumTest()
        {
            int[] input = { 1, 4, 3, 2 };
            int expected = 4;

            Assert.AreEqual(expected, new ArrayPartitionI().ArrayPairSum(input));
        }

        [Test()]
        public void ArrayPairSumTest1()
        {
            int[] input = { -10, 5, -10, 10 };
            int expected = -5;

            Assert.AreEqual(expected, new ArrayPartitionI().ArrayPairSum(input));
        }

        [Test()]
        public void ArrayPairSumTest2()
        {
            int[] input = { -10, 5, -10, 10, -30, 90 };
            int expected = -30;

            Assert.AreEqual(expected, new ArrayPartitionI().ArrayPairSum2(input));
        }

        [Test()]
        public void ArrayPairSum2Test()
        {
            int[] input = { 1, 4, 3, 2 };
            int expected = 4;

            Assert.AreEqual(expected, new ArrayPartitionI().ArrayPairSum2(input));
        }

        [Test()]
        public void ArrayPairSum2Test1()
        {
            int[] input = { -10, 5, -10, 10 };
            int expected = -5;

            Assert.AreEqual(expected, new ArrayPartitionI().ArrayPairSum2(input));
        }

        [Test()]
        public void ArrayPairSum2Test2()
        {
            int[] input = { -10, 5, -10, 10, -30, 90 };
            int expected = -30;

            Assert.AreEqual(expected, new ArrayPartitionI().ArrayPairSum2(input));
        }
    }
}