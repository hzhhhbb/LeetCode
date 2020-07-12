using System;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 485. 最大连续1的个数
    /// </summary>
    public class MaxConsecutiveOnes
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
