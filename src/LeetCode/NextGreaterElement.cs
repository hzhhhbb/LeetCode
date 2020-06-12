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
            Dictionary<int, int> map = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count > 0 && nums2[i] > stack.Peek())
                {
                    map.Add(stack.Pop(), nums2[i]);
                }

                stack.Push(nums2[i]);
            }

            while (stack.Count > 0)
            {
                map.Add(stack.Pop(), -1);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                results[i] = map[nums1[i]];
            }

            return results;
        }
    }
}
