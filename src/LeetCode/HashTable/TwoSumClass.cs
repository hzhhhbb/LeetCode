using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 1. 两数之和
    /// </summary>
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> kv = new Dictionary<int, int>(nums.Length - 1);
            for (var index = 0; index < nums.Length; index++)
            {
                int num = nums[index];
                if (kv.ContainsKey(target - num))
                {
                    return new int[] { kv[target - num], index };
                }

                kv.TryAdd(num, index);
            }

            return new int[] { };
        }
    }
}