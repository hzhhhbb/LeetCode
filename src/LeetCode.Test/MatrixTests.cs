using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class MatrixTests
    {
        [Test()]
        public void UpdateMatrixTest()
        {
            int[][] input=new int[][]
                              {
                                  new int[]{0,0,0},
                                  new int[]{0,1,0},
                                  new int[]{0,0,0},
                              };
            Assert.AreEqual(input,new Matrix().UpdateMatrix(input));

            int[][] input1 = new int[][]
                                {
                                    new int[]{0,0,0},
                                    new int[]{0,1,0},
                                    new int[]{1,1,1},
                                };
            int[][] output1 = new int[][]
                                 {
                                     new int[]{0,0,0},
                                     new int[]{0,1,0},
                                     new int[]{1,2,1},
                                 };

            Assert.AreEqual(output1, new Matrix().UpdateMatrix(input1));

        }
    }
}