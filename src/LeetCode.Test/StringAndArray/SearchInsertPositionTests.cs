
using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class SearchInsertPositionTests
    {
        [Test()]
        public void SearchInsertTest()
        {
            int[] array = {1, 3, 5, 6};
            Assert.AreEqual(2,new SearchInsertPosition().SearchInsert(array,5));

            Assert.AreEqual(1,new SearchInsertPosition().SearchInsert(array,2));

            Assert.AreEqual(4,new SearchInsertPosition().SearchInsert(array,7));

            Assert.AreEqual(0,new SearchInsertPosition().SearchInsert(array,0));

        }
    }
}