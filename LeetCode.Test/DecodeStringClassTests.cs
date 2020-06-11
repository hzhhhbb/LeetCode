using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class DecodeStringClassTests
    {
        [Test()]
        public void DecodeStringTest()
        {
            string s = "3[a]2[bc]";
            Assert.AreEqual("aaabcbc",new DecodeStringClass().DecodeString(s));

            string s1 = "3[a2[c]]";
            Assert.AreEqual("accaccacc", new DecodeStringClass().DecodeString(s1));

            string s2 = "2[abc]3[cd]ef";
            Assert.AreEqual("abcabccdcdcdef", new DecodeStringClass().DecodeString(s2));

            string s3 = "abc3[cd]xyz";
            Assert.AreEqual("abccdcdcdxyz", new DecodeStringClass().DecodeString(s3));

            string s4 = "[cd]xyz";
            Assert.AreEqual("cdxyz", new DecodeStringClass().DecodeString(s4));

        }
    }
}