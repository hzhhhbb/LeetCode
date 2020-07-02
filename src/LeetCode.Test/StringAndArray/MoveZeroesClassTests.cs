using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class MoveZeroesClassTests
    {
        [Test()]
        public void MoveZeroesTest()
        {
            int[] input = {0,1,0,3,12};
            int[] expected = {1, 3, 12, 0, 0};

            new MoveZeroesClass().MoveZeroes(input);

            Assert.AreEqual(expected,input);
        }

        [Test()]
        public void MoveZeroesTest1()
        {
            int[] input = {1,0,0,3,12};
            int[] expected = {1, 3, 12, 0, 0};

            new MoveZeroesClass().MoveZeroes(input);

            Assert.AreEqual(expected,input);
        }

        [Test()]
        public void MoveZeroesTest2()
        {
            int[] input = {1,2,3,4,12};
            int[] expected = {1, 2, 3, 4, 12};

            new MoveZeroesClass().MoveZeroes(input);

            Assert.AreEqual(expected,input);
        }

        [Test()]
        public void MoveZeroesTest3()
        {
            int[] input = {1,2,3,4,0};
            int[] expected = {1, 2, 3, 4, 0};

            new MoveZeroesClass().MoveZeroes(input);

            Assert.AreEqual(expected,input);
        }
    }
}