using NUnit.Framework;
using LeetCode.HashTable;

using System;
using System.Collections.Generic;
using System.Text;

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
            Assert.AreEqual(expected,new JewelsAndStones().NumJewelsInStones(J,S));
        }

        [Test()]
        public void NumJewelsInStonesTest1()
        {
            string J = "z";
            string S = "ZZ";
            int expected = 0;
            Assert.AreEqual(expected,new JewelsAndStones().NumJewelsInStones(J,S));
        }

        [Test()]
        public void NumJewelsInStonesTest2()
        {
            string J = "";
            string S = "ZZ";
            int expected = 0;
            Assert.AreEqual(expected,new JewelsAndStones().NumJewelsInStones(J,S));
        }

        [Test()]
        public void NumJewelsInStonesTest3()
        {
            string J = "a";
            string S = "";
            int expected = 0;
            Assert.AreEqual(expected,new JewelsAndStones().NumJewelsInStones(J,S));
        }
    }
}