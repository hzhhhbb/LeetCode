using NUnit.Framework;

using LeetCode.HashTable;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class ValidSudokuTests
    {
        [Test()]
        public void IsValidSudokuTest()
        {
            char[][] input = new char[][] { new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }, new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' }, new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' }, new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' }, new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' }, new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' }, new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' }, new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' }, new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }, };
            bool expected = true;
            Assert.AreEqual(expected, new ValidSudoku().IsValidSudoku(input));
        }

        [Test()]
        public void IsValidSudokuTest1()
        {
            char[][] input = new char[][] { new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' }, new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' }, new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' }, new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' }, new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' }, new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' }, new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' }, new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' }, new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }, };
            bool expected = false;
            Assert.AreEqual(expected, new ValidSudoku().IsValidSudoku(input));
        }

        [Test()]
        public void IsValidSudokuTest2()
        {
            char[][] input = new char[][] { new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }, new char[] { '6', '5', '.', '1', '9', '5', '.', '.', '.' }, new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' }, new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' }, new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' }, new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' }, new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' }, new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' }, new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }, };
            bool expected = false;
            Assert.AreEqual(expected, new ValidSudoku().IsValidSudoku(input));
        }
    }
}