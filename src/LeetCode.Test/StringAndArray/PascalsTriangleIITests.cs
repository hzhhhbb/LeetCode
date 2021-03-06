﻿using System.Collections.Generic;

using LeetCode.StringAndArray;

using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class PascalsTriangleIITests
    {
        [Test()]
        public void GetRowTest()
        {
            int rowIndex = 3;
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 1 });
            expected.Add(new List<int>() { 1, 1 });
            expected.Add(new List<int>() { 1, 2, 1 });
            expected.Add(new List<int>() { 1, 3, 3, 1 });

            Assert.AreEqual(expected[rowIndex], new PascalsTriangleII().GetRow(rowIndex));
        }
    }
}