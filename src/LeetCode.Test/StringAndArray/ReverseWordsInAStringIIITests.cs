namespace LeetCode.Tests.StringAndArray
{
    using LeetCode.StringAndArray;

    using NUnit.Framework;

    [TestFixture()]
    public class ReverseWordsInAStringIIITests
    {
        [Test()]
        public void ReverseWordsTest()
        {
            string input = "Let's take LeetCode contest";
            string expected = "s'teL ekat edoCteeL tsetnoc";

            Assert.AreEqual(expected, new ReverseWordsInAStringIII().ReverseWords(input));
        }
    }
}