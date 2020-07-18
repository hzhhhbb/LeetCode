using System;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 136. 只出现一次的数字
    /// </summary>
   public class SingleNumberClass
    {
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            int leftIndex = 0;
            int rightIndex = 1;

            while (leftIndex<nums.Length-1&&rightIndex<nums.Length-1)
            {
                if (nums[leftIndex] != nums[rightIndex])
                {
                    return nums[leftIndex];
                }

                leftIndex+=2;
                rightIndex+=2;
            }

            return nums[leftIndex];
        }
        public int SingleNumber1(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result = result ^ num;
            }

            return result;
        }
    }
}
/*
 * # 方法一（修改了原来的数组）
 * 排序后用双指针
 *
 * # 方法二
 * 异或运算满足交换律和结合律，全部数的异或运算结果则为只出现一次的数字
 * a+b+a=b+a+a=b+(a+a)=b+0=b
 */
