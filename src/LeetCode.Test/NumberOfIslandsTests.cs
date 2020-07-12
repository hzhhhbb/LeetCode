using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class NumberOfIslandsTests
    {
        [Test()]
        public void NumIslandsTest()
        {  
            char[][] grid = new char[][]
                               {
                                   new char[5] { '1', '1', '0', '0', '0' },
                                   new char[5] { '1', '1', '0', '0', '0' },
                                   new char[5] { '0', '0', '1', '0', '0' },
                                   new char[5] { '0', '0', '0', '1', '1' },
                               };

            Assert.AreEqual(3,    new NumberOfIslands().NumIslands(grid));
        }

        [Test()]
        public void NumIslandsByDFSTest()
        {
            char[][] grid2 = new char[][]
                                 {
                                     new char[5] { '1', '1', '0', '0', '0' },
                                     new char[5] { '1', '1', '0', '0', '0' },
                                     new char[5] { '0', '0', '1', '0', '0' },
                                     new char[5] { '0', '0', '0', '1', '1' },
                                 };

            Assert.AreEqual(3,    new NumberOfIslands().NumIslandsByDFS(grid2));
        }
    }
}