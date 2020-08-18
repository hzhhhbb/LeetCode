using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 220. 存在重复元素 III（超出时间限制）
    /// </summary>
    public class ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            SortedSet<long?> set = new SortedSet<long?>();
            for (int i = 0; i < nums.Length; i++)
            {
                //滑动窗口内有大于当前元素的第一个值、并且它们的差小于等于t
                // O(N)复杂度
                var successor = set.FirstOrDefault(u => u >= nums[i]);
                if (successor!=null && successor - nums[i] <= t)
                {
                    return true;
                }

                //滑动窗口内有小于当前元素的第一个值、并且它们的差小于等于t
                // O(N)复杂度
                var predecessor = set.LastOrDefault(u => u <= nums[i]);
                if (predecessor!=null && nums[i] - predecessor <= t)
                {
                    return true;
                }

                set.Add(nums[i]);

                //维持set的大小在k大小的滑动窗口内
                if (set.Count > k)
                {
                    set.Remove(nums[i - k]);
                }
            }

            return false;
        }

        /* 使用平衡二叉搜索树
         * 在k大小的滑动窗口内，寻找是否存在num[i]-nums[j]的绝对值小于等于t的情况即可
         */
    }
}