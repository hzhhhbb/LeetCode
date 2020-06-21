using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class ReverseWordsInAStringTests
    {
        [Test()]
        public void ReverseWordsTest()
        {
            string originStr = "the sky is blue";
            string expected="blue is sky the";

            string reversedStr =new ReverseWordsInAString().ReverseWords(originStr);

            Assert.AreEqual(expected,reversedStr);
        }

        [Test()]
        public void ReverseWordsTest1()
        {
            string originStr =  "  hello   world!  ";
            string expected = "world! hello";

            string reversedStr =new ReverseWordsInAString().ReverseWords(originStr);

            Assert.AreEqual(expected,reversedStr);
        }

        [Test()]
        public void ReverseWordsTest3()
        {
            string originStr =  " ";
            string expected = "";

            string reversedStr =new ReverseWordsInAString().ReverseWords(originStr);

            Assert.AreEqual(expected,reversedStr);
        }

        [Test()]
        public void ReverseWordsTest4()
        {
            string originStr =  "    aaaaa  ";
            string expected = "aaaaa";

            string reversedStr =new ReverseWordsInAString().ReverseWords(originStr);

            Assert.AreEqual(expected,reversedStr);
        }

        [Test()]
        public void ReverseWordsTest5()
        {
            string originStr =  "";
            string expected = "";

            string reversedStr =new ReverseWordsInAString().ReverseWords(originStr);

            Assert.AreEqual(expected,reversedStr);
        }

    }
}