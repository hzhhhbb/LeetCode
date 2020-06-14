using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class MergeIntervalsTests
    {
        [Test()]
        public void MergeTest()
        {
            int [][] intervals=new int[][]
            {
                new int[]{1,3}, 
                new int[]{2,6}, 
                new int[]{8,10}, 
                new int[]{15,18}, 
            };
            int [][] mergedIntervals=new int[][]
            {
                new int[]{1,6}, 
                new int[]{8,10}, 
                new int[]{15,18}, 
            };
            Assert.AreEqual(mergedIntervals,new MergeIntervals().Merge(intervals));

            intervals=new int[][]
            {
                new int[]{1,4}, 
                new int[]{4,5}, 
            };
            mergedIntervals=new int[][]
            {
                new int[]{1,5}, 
            };
            Assert.AreEqual(mergedIntervals,new MergeIntervals().Merge(intervals));

            intervals=new int[][]
            {
                new int[]{1,2}, 
                new int[]{2,3}, 
                new int[]{3,4}, 
                new int[]{4,5}, 
                new int[]{5,6}, 
                new int[]{7,8}, 
                new int[]{8,9}, 
                new int[]{10,15}, 
                new int[]{15,16}, 
                new int[]{17,18}, 
            };
            mergedIntervals=new int[][]
            {
                new int[]{1,6}, 
                new int[]{7,9}, 
                new int[]{10,16}, 
                new int[]{17,18}, 
            };
            Assert.AreEqual(mergedIntervals,new MergeIntervals().Merge(intervals));

            intervals=new int[][]
            {
                new int[]{1,9}, 
                new int[]{2,5}, 
                new int[]{19,20}, 
                new int[]{10,11}, 
                new int[]{12,20}, 
                new int[]{0,3}, 
                new int[]{0,1}, 
                new int[]{0,2}, 
            };
            mergedIntervals=new int[][]
            {
                new int[]{0,9}, 
                new int[]{10,11}, 
                new int[]{12,20}, 
            };
            Assert.AreEqual(mergedIntervals,new MergeIntervals().Merge(intervals));

            intervals=new int[][]{};
            mergedIntervals=new int[][]{};
            Assert.AreEqual(mergedIntervals,new MergeIntervals().Merge(intervals));
        }
    }
}