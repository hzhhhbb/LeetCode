using NUnit.Framework;
using LeetCode;

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class TargetSumTests
    {
        [Test()]
        public void FindTargetSumWaysTest()
        {
            int[] temperatures = {73, 74, 75, 71, 69, 72, 76, 73};
                 var result = new DailyTemperaturesClass().DailyTemperatures(temperatures);
            Assert.AreEqual("1, 1, 4, 2, 1, 1, 0, 0",string.Join(", ",result));
        }
    }
}