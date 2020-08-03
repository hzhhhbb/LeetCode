using NUnit.Framework;

using LeetCode.HashTable;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class IntersectionOfTwoArraysIITests
    {
        [Test()]
        public void IntersectTest()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new int[] { 2, 2 };

            Assert.AreEqual(expected, new IntersectionOfTwoArraysII().Intersect(nums1, nums2));
        }

        [Test()]
        public void IntersectTest1()
        {
            int[] nums1 = new int[] { 4, 9, 5 };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
            int[] expected = new int[] { 9, 4 };

            Assert.AreEqual(expected, new IntersectionOfTwoArraysII().Intersect(nums1, nums2));
        }

        [Test()]
        public void IntersectTest2()
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
            int[] expected = new int[] { };

            Assert.AreEqual(expected, new IntersectionOfTwoArraysII().Intersect(nums1, nums2));
        }

        [Test()]
        public void IntersectTest3()
        {
            int[] nums1 = new int[] { 9, 4, 9, 8, 4 };
            int[] nums2 = new int[] { };
            int[] expected = new int[] { };

            Assert.AreEqual(expected, new IntersectionOfTwoArraysII().Intersect(nums1, nums2));
        }
    }
}