using LeetCode.StringAndArray;

using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class ZeroMatrixLCCITests
    {
        [Test()]
        public void SetZeroesTest()
        {
            int[][] matrix = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 }, };

            int[][] result = new int[][] { new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 1 }, };
            new ZeroMatrixLCCI().SetZeroes(matrix);

            Assert.AreEqual(result, matrix);
        }

        [Test()]
        public void SetZeroesTest1()
        {
            int[][] matrix = new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 }, };

            int[][] result = new int[][] { new int[] { 0, 0, 0, 0 }, new int[] { 0, 4, 5, 0 }, new int[] { 0, 3, 1, 0 }, };
            new ZeroMatrixLCCI().SetZeroes(matrix);

            Assert.AreEqual(result, matrix);
        }
    }
}