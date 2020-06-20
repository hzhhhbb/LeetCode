using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class LongestCommonPrefixClassTests
    {
        [Test()]
        public void LongestCommonPrefixTest()
        {
            string[] strs={"flower","flow","flight"};

            string commonPrefix = "fl";

            Assert.AreEqual(commonPrefix,new LongestCommonPrefixClass().LongestCommonPrefix(strs));
        }

        [Test()]
        public void LongestCommonPrefixTest1()
        {
            string[] strs={"dog","racecar","car"};

            string commonPrefix = "";

            Assert.AreEqual(commonPrefix,new LongestCommonPrefixClass().LongestCommonPrefix(strs));
        }

        [Test()]
        public void LongestCommonPrefixTest2()
        {
            string[] strs={"dog"};

            string commonPrefix = "dog";

            Assert.AreEqual(commonPrefix,new LongestCommonPrefixClass().LongestCommonPrefix(strs));
        }

        [Test()]
        public void LongestCommonPrefixTest3()
        {
            string[] strs={"aa","a"};

            string commonPrefix = "a";

            Assert.AreEqual(commonPrefix,new LongestCommonPrefixClass().LongestCommonPrefix(strs));
        }
    }
}