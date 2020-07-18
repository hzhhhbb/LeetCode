using LeetCode.HashTable;
using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class ContainsDuplicateClassTests
    {
        [Test()]
        public void ContainsDuplicateTest()
        {
            int[] input = new int[] {1, 2, 3, 1};
            bool expected = true;
            Assert.AreEqual(expected, new ContainsDuplicateClass().ContainsDuplicate(input));
        }

        [Test()]
        public void ContainsDuplicateTest1()
        {
            int[] input = new int[] {1, 2, 3, 4};
            bool expected = false;
            Assert.AreEqual(expected, new ContainsDuplicateClass().ContainsDuplicate(input));
        }

        [Test()]
        public void ContainsDuplicateTest2()
        {
            int[] input = new int[] { };
            bool expected = false;
            Assert.AreEqual(expected, new ContainsDuplicateClass().ContainsDuplicate(input));
        }

        [Test()]
        public void ContainsDuplicateTest3()
        {
            int[] input = null;
            bool expected = false;
            Assert.AreEqual(expected, new ContainsDuplicateClass().ContainsDuplicate(input));
        }
    }
}