using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 27. 移除元素
    /// </summary>
   public class RemoveElementClass
    {
        public int RemoveElement(int[] nums, int val)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            return slow;
        }
    }
}
