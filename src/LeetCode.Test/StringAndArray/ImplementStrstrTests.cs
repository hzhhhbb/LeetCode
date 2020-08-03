using LeetCode.StringAndArray;

using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class ImplementStrstrTests
    {
        [Test()]
        public void StrStrTest()
        {
            string haystack = "hello";
            string needle = "ll";
            int expectation = 2;

            Assert.AreEqual(expectation, new ImplementStrstr().StrStr(haystack, needle));
        }

        [Test()]
        public void StrStrTest1()
        {
            string haystack = "aaaaa";
            string needle = "bba";
            int expectation = -1;

            Assert.AreEqual(expectation, new ImplementStrstr().StrStr(haystack, needle));
        }

        [Test()]
        public void StrStrTest2()
        {
            string haystack = "aaaaa";
            string needle = string.Empty;
            int expectation = 0; // 我觉得这里应该返回-1，c#的indexof就是返回-1

            Assert.AreEqual(expectation, new ImplementStrstr().StrStr(haystack, needle));
        }

        [Test()]
        public void StrStrTest3()
        {
            string haystack = "mississippi";
            string needle = "issip";
            int expectation = 4;

            Assert.AreEqual(expectation, new ImplementStrstr().StrStr(haystack, needle));
        }
    }
}