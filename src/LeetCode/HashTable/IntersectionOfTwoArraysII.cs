namespace LeetCode.HashTable
{
    using System.Collections.Generic;

    /// <summary>
    /// 350. 两个数组的交集 II
    /// </summary>
    public class IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length)
            {
                return this.Intersect(nums2, nums1);
            }

            // 统计nums1数字出现的次数
            Dictionary<int, int> numAndTimes = new Dictionary<int, int>();
            foreach (int i in nums1)
            {
                if (numAndTimes.ContainsKey(i))
                {
                    numAndTimes[i] = numAndTimes[i] + 1;
                }
                else
                {
                    numAndTimes.Add(i, 1);
                }
            }

            List<int> repeatedNum = new List<int>();
            foreach (int i in nums2)
            {
                if (numAndTimes.ContainsKey(i))
                {
                    if (numAndTimes[i] > 0)
                    {
                        repeatedNum.Add(i);
                        numAndTimes[i] = numAndTimes[i] - 1;
                    }
                }
            }

            return repeatedNum.ToArray();
        }
    }
}