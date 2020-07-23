using NUnit.Framework;
using LeetCode.HashTable;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class ContainsDuplicateIITests
    {
        [Test()]
        public void ContainsNearbyDuplicateTest()
        {
            int[] nums=new int[]{1,2,3,1};
            int k = 3;
            bool expected = true;

            Assert.AreEqual(expected,new ContainsDuplicateII().ContainsNearbyDuplicate(nums,k));
        }

        [Test()]
        public void ContainsNearbyDuplicateTest1()
        {
            int[] nums=new int[]{1,0,1,1};
            int k = 1;
            bool expected = true;

            Assert.AreEqual(expected,new ContainsDuplicateII().ContainsNearbyDuplicate(nums,k));
        }

        [Test()]
        public void ContainsNearbyDuplicateTest2()
        {
            int[] nums=new int[]{1,2,3,1,2,3};
            int k = 2;
            bool expected = false;

            Assert.AreEqual(expected,new ContainsDuplicateII().ContainsNearbyDuplicate(nums,k));
        }
    }
}