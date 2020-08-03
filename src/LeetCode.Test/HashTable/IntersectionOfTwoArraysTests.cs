using LeetCode.HashTable;

using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class IntersectionOfTwoArraysTests
    {
        [Test()]
        public void IntersectionTest()
        {
            int[] nums1 = new int[] { 1, 2, 3, 4 };
            int[] nums2 = new int[] { 5, 6 };
            int[] expected = new int[] { };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest1()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new[] { 2 };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest2()
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new int[] { };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest3()
        {
            int[] nums1 = new int[] { 1 };
            int[] nums2 = new int[] { };
            int[] expected = new int[] { };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest4()
        {
            int[] nums1 = new int[] { 1, 2, 3, 4 };
            int[] nums2 = new int[] { 5, 6 };
            int[] expected = new int[] { };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection1(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest5()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new[] { 2 };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection1(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest6()
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new int[] { };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection1(nums1, nums2));
        }

        [Test()]
        public void IntersectionTest7()
        {
            int[] nums1 = new int[] { 1 };
            int[] nums2 = new int[] { };
            int[] expected = new int[] { };
            Assert.AreEqual(expected, new IntersectionOfTwoArrays().Intersection1(nums1, nums2));
        }
    }
}