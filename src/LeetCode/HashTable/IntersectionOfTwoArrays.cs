﻿using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 349. 两个数组的交集
    /// </summary>
    public class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (!nums1.Any() || !nums2.Any())
            {
                return new int[0];
            }

            HashSet<int> result = new HashSet<int>();
            HashSet<int> set1 = new HashSet<int>(nums1);
            foreach (int num in nums2)
            {
                if (set1.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        public int[] Intersection1(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }
    }
}
/* # 方法一
 * 使用两个HashSet即可
 *
 * # 方法二
 * 使用内置函数
 */