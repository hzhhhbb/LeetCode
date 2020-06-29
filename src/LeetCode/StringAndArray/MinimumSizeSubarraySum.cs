using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 209. 长度最小的子数组
    /// </summary>
   public class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int minimumSize = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum = sum + nums[j];
                    if (sum >= s)
                    {
                        minimumSize = Math.Min(minimumSize, j - i + 1);
                        break;
                    }
                }
            }

            return minimumSize == int.MaxValue ? 0 : minimumSize;
        }

        public int MinSubArrayLen1(int s, int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int start = 0;
            int end = 0;
            int minimumSize = int.MaxValue;
            int sum = 0;
            while (end<nums.Length)
            {
                sum += nums[end];
                while (sum>=s)
                {
                    minimumSize = Math.Min(minimumSize, end - start + 1);
                    sum = sum - nums[start];
                    start++;
                }

                end++;
            }

            return minimumSize == int.MaxValue ? 0 : minimumSize;
        }
    }
}
/*
 * 方法一：最简单的暴力
 * 方法二：双指针
 */
