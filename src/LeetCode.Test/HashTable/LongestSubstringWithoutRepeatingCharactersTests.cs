using LeetCode.HashTable;

using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Test()]
        public void LengthOfLongestSubstringTest()
        {
            string input = "abcabcbb";
            int expected = 3;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest1()
        {
            string input = "12345678901abcdefghijk";
            int expected = 21;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest2()
        {
            string input = "12345678901abcd1efghijk";
            int expected = 14;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest3()
        {
            string input = string.Empty;
            int expected = 0;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest4()
        {
            string input = "1234567890zxcvbnmasdfghjkl";
            int expected = 26;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest5()
        {
            string input = "abba";
            int expected = 2;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest6()
        {
            string input = "ababcabababababababab";
            int expected = 3;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest7()
        {
            string input = "aaaaaaaaaaaaaaa";
            int expected = 1;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest8()
        {
            string input = "abcaaaaaaaaaaaaaaabbbbbbbbbbabcde";
            int expected = 5;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }

        [Test()]
        public void LengthOfLongestSubstringTest9()
        {
            string input = "abcdeaaaaaaaaabbbbabababababaababababababb";
            int expected = 5;
            Assert.AreEqual(expected, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input));
        }
    }
}