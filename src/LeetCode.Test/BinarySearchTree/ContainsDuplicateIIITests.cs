using NUnit.Framework;
using LeetCode.BinarySearchTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class ContainsDuplicateIIITests
    {
        [Test()]
        public void ContainsNearbyAlmostDuplicateTest()
        {
            int[] nums = {1, 2, 3, 1};
            int k = 3;
            int t = 0;
            bool expected = true;
            bool result = new ContainsDuplicateIII().ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void ContainsNearbyAlmostDuplicateTest1()
        {
            int[] nums = {1,0,1,1};
            int k =1;
            int t = 2;
            bool expected = true;
            bool result = new ContainsDuplicateIII().ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void ContainsNearbyAlmostDuplicateTest2()
        {
            int[] nums = {1,5,9,1,5,9};
            int k = 2;
            int t = 3;

            bool expected = false;
            bool result = new ContainsDuplicateIII().ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void ContainsNearbyAlmostDuplicateTest3()
        {
            int[] nums = {7,2,8};
            int k = 2;
            int t = 1;

            bool expected = true;
            bool result = new ContainsDuplicateIII().ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.AreEqual(expected,result);
        }
    }
}