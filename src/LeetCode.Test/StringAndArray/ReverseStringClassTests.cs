using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class ReverseStringClassTests
    {
        [Test()]
        public void ReverseStringTest()
        {
            char[] origin = {'h', 'e', 'l', 'l', 'o'};
            char[] reversed = {'o','l','l','e','h'};

            new ReverseStringClass().ReverseString(origin);

            Assert.AreEqual(reversed,origin);
        }

        [Test()]
        public void ReverseStringTest1()
        {
            char[] origin = {'H','a','n','n','a','h'};
            char[] reversed = {'h','a','n','n','a','H'};

            new ReverseStringClass().ReverseString(origin);

            Assert.AreEqual(reversed,origin);
        }
    }
}