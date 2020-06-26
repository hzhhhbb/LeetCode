using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class maxConsecutiveOnesTests
    {
        [Test()]
        public void FindMaxConsecutiveOnesTest()
        {
            int[] nums = {1, 1, 0, 1, 1, 1};
            int expected = 3;

            Assert.AreEqual(expected,new maxConsecutiveOnes().FindMaxConsecutiveOnes(nums));
        }

        [Test()]
        public void FindMaxConsecutiveOnesTest1()
        {
            int[] nums = {1, 1, 0, 1, 1, 1,0,0,0,1,1,1,1,0,1,1,1,1,1,1,1,1};
            int expected = 8;

            Assert.AreEqual(expected,new maxConsecutiveOnes().FindMaxConsecutiveOnes(nums));
        }

        [Test()]
        public void FindMaxConsecutiveOnesTest2()
        {
            int[] nums = {1, 1};
            int expected = 2;

            Assert.AreEqual(expected,new maxConsecutiveOnes().FindMaxConsecutiveOnes(nums));
        }

        [Test()]
        public void FindMaxConsecutiveOnesTest3()
        {
            int[] nums = {0, 0};
            int expected = 0;

            Assert.AreEqual(expected,new maxConsecutiveOnes().FindMaxConsecutiveOnes(nums));
        }

        [Test()]
        public void FindMaxConsecutiveOnesTest4()
        {
            int[] nums = {0};
            int expected = 0;

            Assert.AreEqual(expected,new maxConsecutiveOnes().FindMaxConsecutiveOnes(nums));
        }


        [Test()]
        public void FindMaxConsecutiveOnesTest5()
        {
            int[] nums = {1};
            int expected = 1;

            Assert.AreEqual(expected,new maxConsecutiveOnes().FindMaxConsecutiveOnes(nums));
        }
    }
}