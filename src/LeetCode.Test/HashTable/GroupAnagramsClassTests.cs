using NUnit.Framework;
using LeetCode.HashTable;
using System.Collections.Generic;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class GroupAnagramsClassTests
    {
        [Test()]
        public void GroupAnagramsTest()
        {
            string[] input = {"eat", "tea", "tan", "ate", "nat", "bat"};
            List<List<string>> expected = new List<List<string>>();
            expected.Add(new List<string>(){"eat","tea","ate"});
            expected.Add(new List<string>(){"tan","nat"});
            expected.Add(new List<string>(){"bat"});

            Assert.AreEqual(expected,new GroupAnagramsClass().GroupAnagrams(input));
        }
    }
}