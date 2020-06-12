using System;

namespace LeetCode
{
    /// <summary>
    /// 494. 目标和
    /// </summary>
    public class TargetSum
    {
        private int Count = 0;

        public int FindTargetSumWays(int[] nums, int S)
        {
            this.Calculate(nums, 0, 0, S);
            return this.Count;
        }

        public void Calculate(int[] nums, int i, int sum, int S)
        {
            if (i == nums.Length)
            {
                if (sum == S)
                {
                    this.Count++;
                }
            }
            else
            {
                this.Calculate(nums, i + 1, sum + nums[i], S);
                this.Calculate(nums, i + 1, sum - nums[i], S);
            }
        }
    }
}