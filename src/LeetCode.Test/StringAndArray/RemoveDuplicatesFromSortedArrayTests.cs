using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Test()]
        public void RemoveDuplicatesTest()
        {
            int[] input = {1, 1, 2};
            int expected = 2;

            Assert.AreEqual(expected,new RemoveDuplicatesFromSortedArray().RemoveDuplicates(input));
        }

        [Test()]
        public void RemoveDuplicatesTest1()
        {
            int[] input = {0,0,1,1,1,2,2,3,3,4};
            int expected = 5;

            Assert.AreEqual(expected,new RemoveDuplicatesFromSortedArray().RemoveDuplicates(input));
        }
        
        [Test()]
        public void RemoveDuplicatesTest2()
        {
            int[] input = {};
            int expected = 0;

            Assert.AreEqual(expected,new RemoveDuplicatesFromSortedArray().RemoveDuplicates(input));
        }

        [Test()]
        public void RemoveDuplicatesTest3()
        {
            int[] input = {0,0,0,1,1,1,1,1,1,1,1,2,2,3,4,5,6,7,7,8,9};
            int expected = 10;

            Assert.AreEqual(expected,new RemoveDuplicatesFromSortedArray().RemoveDuplicates(input));
        }
    }
}