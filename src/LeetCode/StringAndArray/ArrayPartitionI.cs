using System;
using System.Linq;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 561. 数组拆分 I
    /// </summary>
    public class ArrayPartitionI
    {
        public int ArrayPairSum(int[] nums)
        {
            if (nums.Length == 2)
            {
                return Math.Min(nums[0], nums[1]);
            }

            nums = nums.OrderBy(u => u).ToArray();

            int start = 0;
            int end = nums.Length - 2;
            int result = 0;

            while (start < end)
            {
                result = result + nums[start] + nums[end];

                start += 2;
                end -= 2;
            }

            if (start == end)
            {
                result += nums[start];
            }

            return result;
        }

        public int ArrayPairSum2(int[] nums)
        {
            nums = nums.OrderBy(u => u).ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}
/*
 * # 审题
 * 题目中限定了数组数量是2n，那么数组数量一定是偶数,所以不需要考虑数组数量为奇数的情况
 * 要求是求出最大值，那么就使每对的数最大，所以最小数必然要和第二小的数组成一对
 * # 解法
 * 两种解法，双指针和普通循环。相同点都是需要先按照升序排序，然后取两个数中的最小数相加即可
 */