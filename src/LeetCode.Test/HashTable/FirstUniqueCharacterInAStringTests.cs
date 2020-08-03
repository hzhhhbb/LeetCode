using LeetCode.HashTable;

using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class FirstUniqueCharacterInAStringTests
    {
        [Test()]
        public void FirstUniqCharTest()
        {
            string input = "leetcode";
            int expected = 0;

            Assert.AreEqual(expected, new FirstUniqueCharacterInAString().FirstUniqChar(input));
        }

        [Test()]
        public void FirstUniqCharTest1()
        {
            string input = "loveleetcode";
            int expected = 2;

            Assert.AreEqual(expected, new FirstUniqueCharacterInAString().FirstUniqChar(input));
        }

        [Test()]
        public void FirstUniqCharTest2()
        {
            string input = "lllllllllll";
            int expected = -1;

            Assert.AreEqual(expected, new FirstUniqueCharacterInAString().FirstUniqChar(input));
        }

        [Test()]
        public void FirstUniqCharTest3()
        {
            string input = "luluiliooi";
            int expected = -1;

            Assert.AreEqual(expected, new FirstUniqueCharacterInAString().FirstUniqChar(input));
        }
    }
}