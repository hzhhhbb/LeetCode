using LeetCode.HashTable;
using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class SingleNumberClassTests
    {
        [Test()]
        public void SingleNumberTest()
        { 
            int[] input = new int[] {1, 2, 3, 1,2};
            int expected = 3;
            Assert.AreEqual(expected,new SingleNumberClass().SingleNumber(input));
        }

        [Test()]
        public void SingleNumberTest1()
        {
            int[] input = new int[] {1, 2, 2, 3,3};
            int expected = 1;
            Assert.AreEqual(expected,new SingleNumberClass().SingleNumber(input));
        }

        [Test()]
        public void SingleNumberTest2()
        { 
            int[] input = new int[] {1, 2, 3, 1,2};
            int expected = 3;
            Assert.AreEqual(expected,new SingleNumberClass().SingleNumber1(input));
        }

        [Test()]
        public void SingleNumberTest3()
        {
            int[] input = new int[] {1, 2, 2, 3,3};
            int expected = 1;
            Assert.AreEqual(expected,new SingleNumberClass().SingleNumber1(input));
        }
    }
}