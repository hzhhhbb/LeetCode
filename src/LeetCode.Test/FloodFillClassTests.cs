using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class FloodFillClassTests
    {
        [Test()]
        public void FloodFillTest()
        {
            int[][] image = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, };
            int sr = 1;
            int sc = 1;
            int newColor = 2;
            int[][] newImage = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 2, 0 }, new int[] { 2, 0, 1 }, };

            Assert.AreEqual(newImage,new FloodFillClass().FloodFill(image, sr,sc,newColor));

            int[][] image1 = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 1 }};
            int sr1 = 1;
            int sc1 = 1;
            int newColor1 = 1;
            int[][] newImage1 = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 1 } };

            Assert.AreEqual(newImage1, new FloodFillClass().FloodFill(image1, sr1, sc1, newColor1));



        }
    }
}