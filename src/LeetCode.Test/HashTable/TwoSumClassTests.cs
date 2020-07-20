using NUnit.Framework;
using LeetCode.HashTable;

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class TwoSumClassTests
    {
        [Test()]
        public void TwoSumTest()
        {
            int[] input=new int[]{2, 7, 11, 15};
            int target = 9;

            int[] expected=new int[]{0,1};
            Assert.AreEqual(expected,new TwoSumClass().TwoSum(input,target));
        }
    }
}