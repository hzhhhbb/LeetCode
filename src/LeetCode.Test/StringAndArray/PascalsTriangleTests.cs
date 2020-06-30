using System.Collections;
using System.Collections.Generic;
using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class PascalsTriangleTests
    {
        [Test()]
        public void GenerateTest()
        {
            int input = 5;
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() {1});
            expected.Add(new List<int>() {1, 1});
            expected.Add(new List<int>() {1, 2, 1});
            expected.Add(new List<int>() {1, 3, 3, 1});
            expected.Add(new List<int>() {1, 4, 6, 4, 1});

            Assert.AreEqual(expected, new PascalsTriangle().Generate(input));
        }

        [Test()]
        public void GenerateTest1()
        {
            int input = 0;
            IList<IList<int>> expected = new List<IList<int>>();

            Assert.AreEqual(expected, new PascalsTriangle().Generate(input));
        }

        [Test()]
        public void GenerateTest2()
        {
            int input = 2;
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() {1});
            expected.Add(new List<int>() {1, 1});

            Assert.AreEqual(expected, new PascalsTriangle().Generate(input));
        }

        [Test()]
        public void GenerateTest3()
        {
            int input = 6;
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() {1});
            expected.Add(new List<int>() {1, 1});
            expected.Add(new List<int>() {1, 2, 1});
            expected.Add(new List<int>() {1, 3, 3, 1});
            expected.Add(new List<int>() {1, 4, 6, 4, 1});
            expected.Add(new List<int>() {1, 5, 10, 10, 5, 1});

            Assert.AreEqual(expected, new PascalsTriangle().Generate(input));
        }
    }
}