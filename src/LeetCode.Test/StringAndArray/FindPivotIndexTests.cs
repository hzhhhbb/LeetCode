using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Test.StringAndArray
{
    [TestFixture()]
    [Timeout(1000)]
    public class FindPivotIndexTests
    {
        [Test()]
        public void PivotIndexTest()
        {
            int [] nums3=new int[0];
            Assert.AreEqual(-1,new FindPivotIndex().PivotIndex(nums3));

            int[] nums = {1, 7, 3, 6, 5, 6};
            Assert.AreEqual(3,new FindPivotIndex().PivotIndex(nums));

            int[] nums1 = {1, 2, 3};
            Assert.AreEqual(-1,new FindPivotIndex().PivotIndex(nums1));

            int[] nums2 = {1, 2,3,4,5,6,7,8,9,10};
            Assert.AreEqual(-1,new FindPivotIndex().PivotIndex(nums2));

            int[] nums4 = {-1, -1, -1, -1, -1, 0};
            Assert.AreEqual(2,new FindPivotIndex().PivotIndex(nums4));
        }
    }
}