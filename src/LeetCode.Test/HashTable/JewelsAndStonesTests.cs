using LeetCode.HashTable;

using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class JewelsAndStonesTests
    {
        [Test()]
        public void NumJewelsInStonesTest()
        {
            string J = "aA";
            string S = "aAAbbbb";
            int expected = 3;
            Assert.AreEqual(expected, new JewelsAndStones().NumJewelsInStones(J, S));
        }

        [Test()]
        public void NumJewelsInStonesTest1()
        {
            string J = "z";
            string S = "ZZ";
            int expected = 0;
            Assert.AreEqual(expected, new JewelsAndStones().NumJewelsInStones(J, S));
        }

        [Test()]
        public void NumJewelsInStonesTest2()
        {
            string J = string.Empty;
            string S = "ZZ";
            int expected = 0;
            Assert.AreEqual(expected, new JewelsAndStones().NumJewelsInStones(J, S));
        }

        [Test()]
        public void NumJewelsInStonesTest3()
        {
            string J = "a";
            string S = string.Empty;
            int expected = 0;
            Assert.AreEqual(expected, new JewelsAndStones().NumJewelsInStones(J, S));
        }
    }
}