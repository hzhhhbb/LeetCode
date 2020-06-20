using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class DiagonalTraverseTests
    {
        [Test()]
        public void FindDiagonalOrderTest()
        {
            int [][] matrix=new int[][]
            {
                new int[]{1, 2, 3 }, 
                new int[]{4, 5, 6 }, 
                new int[]{7, 8, 9 }, 
            };

            int[] result = {1, 2, 4, 7, 5, 3, 6, 8, 9};

            Assert.AreEqual(result,new DiagonalTraverse().FindDiagonalOrder(matrix));
        }

        [Test()]
        public void FindDiagonalOrderTest1()
        {
            int [][] matrix=new int[][]
            {
                new int[]{1, 2, 3, 4 }, 
                new int[]{5, 6, 7, 8 }, 
                new int[]{9, 10, 11, 12 }, 
            };

            int[] result = {1, 2, 5, 9, 6,3, 4, 7, 10, 11,8,12};

            Assert.AreEqual(result,new DiagonalTraverse().FindDiagonalOrder(matrix));
        }
    }
}