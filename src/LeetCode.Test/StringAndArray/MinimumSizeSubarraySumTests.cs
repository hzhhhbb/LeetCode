using NUnit.Framework;
using LeetCode.StringAndArray;

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.StringAndArray.Tests
{
    [TestFixture()]
    public class MinimumSizeSubarraySumTests
    {
        [Test()]
        public void MinSubArrayLenTest()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int sum = 7;
            int expected = 2;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen(sum, nums));
        }

        [Test()]
        public void MinSubArrayLenTest1()
        {
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int sum = 13;
            int expected = 0;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen(sum, nums));
        }

        [Test()]
        public void MinSubArrayLenTest2()
        {
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int sum = 12;
            int expected = 12;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen(sum, nums));
        }

        [Test()]
        public void MinSubArrayLenTest3()
        {
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int sum = 11;
            int expected = 11;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen(sum, nums));
        }

        [Test()]
        public void MinSubArrayLenTest4()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int sum = 4;
            int expected = 1;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen(sum, nums));
        }

        [Test()]
        public void MinSubArrayLenTest5()
        {
            int[] nums = { 2, 6, 1, 2, 4, 3 };
            int sum = 8;
            int expected = 2;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen(sum, nums));
        }

        [Test()]
        public void MinSubArrayLen1Test()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int sum = 7;
            int expected = 2;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen1(sum, nums));
        }

        [Test()]
        public void MinSubArrayLen1Test1()
        {
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int sum = 11;
            int expected = 11;

            Assert.AreEqual(expected, new MinimumSizeSubarraySum().MinSubArrayLen1(sum, nums));
        }
    }
}