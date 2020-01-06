using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 496. 下一个更大元素 I
    /// </summary>
    public class NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] results = new int[nums1.Length];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                dic.Add(nums2[i],i);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                int nextGreaterElement = -1;
                int index = dic[nums1[i]];
                for (int j = index; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        nextGreaterElement = nums2[j];
                        break;
                    }
                }

                results[i] = nextGreaterElement;
            }

            return results;
        }
    }
}
