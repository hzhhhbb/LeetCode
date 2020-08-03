using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class DailyTemperaturesClassTests
    {
        [Test()]
        public void DailyTemperaturesTest()
        {
            int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
            var result = new DailyTemperaturesClass().DailyTemperatures(temperatures);
            Assert.AreEqual("1, 1, 4, 2, 1, 1, 0, 0", string.Join(", ", result));
        }
    }
}