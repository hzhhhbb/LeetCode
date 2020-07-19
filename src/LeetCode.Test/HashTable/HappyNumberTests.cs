using LeetCode.HashTable;
using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class HappyNumberTests
    {
        [Test()]
        public void IsHappyTest()
        {
            int input = 19;
            bool expected = true;
            Assert.AreEqual(expected,new HappyNumber().IsHappy(input));
        }

        [Test()]
        public void IsHappyTest1()
        {
            int input = 0;
            bool expected = false;
            Assert.AreEqual(expected,new HappyNumber().IsHappy(input));
        }

        [Test()]
        public void IsHappyTest2()
        {
            int input = 1;
            bool expected = true;
            Assert.AreEqual(expected,new HappyNumber().IsHappy(input));
        }
    }
}