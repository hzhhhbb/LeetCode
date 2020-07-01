using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 153. 寻找旋转排序数组中的最小值
    /// </summary>
   public class FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int minimum = int.MaxValue;

            while (start<=end)
            {
                minimum = Math.Min(minimum, nums[start]);
                minimum = Math.Min(minimum, nums[end]);
                start++;
                end--;
            }

            return minimum;
        }
    }
}
