using LeetCode.StringAndArray;
using NuGet.Frameworks;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class LongestPalindromicSubstringTests
    {
        [Test()]
        public void LongestPalindromeTest()
        {
            string origin = "babad";
            string expected = "aba";

            string result = new LongestPalindromicSubstring().LongestPalindrome(origin);

            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LongestPalindromeTest1()
        {
            string origin = "08532bab14679";
            string expected = "bab";

            string result = new LongestPalindromicSubstring().LongestPalindrome(origin);
            Assert.AreEqual(expected,result);
        }
    }
}