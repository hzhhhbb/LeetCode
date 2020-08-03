using NUnit.Framework;

using LeetCode.HashTable;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class MinimumIndexSumOfTwoListsTests
    {
        [Test()]
        public void FindRestaurantTest()
        {
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };

            string[] expected = new string[] { "Shogun" };

            Assert.AreEqual(expected, new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2));
        }

        [Test()]
        public void FindRestaurantTest1()
        {
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = new string[] { "KFC", "Shogun", "Burger King" };

            string[] expected = new string[] { "Shogun" };

            Assert.AreEqual(expected, new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2));
        }

        [Test()]
        public void FindRestaurantTest2()
        {
            string[] list1 = new string[] { };
            string[] list2 = new string[] { "KFC", "Shogun", "Burger King" };

            string[] expected = new string[] { };

            Assert.AreEqual(expected, new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2));
        }

        [Test()]
        public void FindRestaurantTest3()
        {
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = new string[] { };

            string[] expected = new string[] { };

            Assert.AreEqual(expected, new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2));
        }

        [Test()]
        public void FindRestaurantTest4()
        {
            // 多个答案
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = new string[] { "Tapioca Express", "Shogun", "Burger King", "KFC" };

            string[] expected = new string[] { "Tapioca Express", "Shogun" };

            Assert.AreEqual(expected, new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2));
        }
    }
}