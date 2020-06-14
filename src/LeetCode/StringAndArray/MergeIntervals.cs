using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LeetCode.StringAndArray
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            intervals = intervals.ToList().OrderBy(item => item[0]).ToArray();
            List<int[]> mergedIntervals = new List<int[]>();

            foreach (var item in intervals)
            {
                int[] newItem = item;

                if (
                    mergedIntervals.Any()
                    && item[0] >= mergedIntervals.Last()[0]
                    && item[0] <= mergedIntervals.Last()[1])
                {
                    newItem = new int[]
                    {
                        mergedIntervals.Last()[0],
                        mergedIntervals.Last()[1] > item[1] ? mergedIntervals.Last()[1] : item[1]
                    };
                    mergedIntervals.Remove(mergedIntervals.Last());
                }

                mergedIntervals.Add(newItem);
            }

            return mergedIntervals.ToArray();
        }
    }
}
/*
 * # 审题
 * 题目中的示例都是有序的，但是题目没有明确输入一定是有序的，所以先排序，按照左端点进行升序排序
 *
 * # 题解
 * 排序后，对相邻的两个区间进行合并即可。可以和上一区间或者下一区间合并，前者的代码较整洁
 */