using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 485. 最大连续1的个数
    /// </summary>
    public class maxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int tempCount = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] == 1)
                {
                    tempCount++;
                    maxCount = Math.Max(maxCount, tempCount);
                }
                else
                {
                    tempCount = 0;
                }
            }

            return maxCount;
        }
    }
}
