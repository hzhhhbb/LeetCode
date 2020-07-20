using NUnit.Framework;
using LeetCode.HashTable;

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class IsomorphicStringsTests
    {
        [Test()]
        public void IsIsomorphicTest()
        {
            //同构字符串
            string str1 = "egg";
            string str2 = "add";
            Assert.IsTrue(new IsomorphicStrings().IsIsomorphic(str1,str2));
        }

        [Test()]
        public void IsIsomorphicTest1()
        {
            //非同构字符串
            string str1 = "foo";
            string str2 = "bar";
            Assert.IsFalse(new IsomorphicStrings().IsIsomorphic(str1,str2));
        }
        [Test()]
        public void IsIsomorphicTest3()
        {
            //非同构字符串
            string str1 = "bar";
            string str2 = "foo";
            Assert.IsFalse(new IsomorphicStrings().IsIsomorphic(str1,str2));
        }
        [Test()]
        public void IsIsomorphicTest2()
        {
            //同构字符串
            string str1 = "paper";
            string str2 = "title";
            Assert.IsTrue(new IsomorphicStrings().IsIsomorphic(str1,str2));
        }
        [Test()]
        public void IsIsomorphicTest4()
        {
            //非同构字符串
            string str1 = "ab";
            string str2 = "aa";
            Assert.IsFalse(new IsomorphicStrings().IsIsomorphic(str1,str2));
        }
    }
}