using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 217. 存在重复元素
    /// </summary>
    public class ContainsDuplicateClass
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            HashSet<int> set = new HashSet<int>(nums.Length);
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                else
                {
                    set.Add(num);
                }
            }

            return false;
        }
    }
}
/*# 方法一
 * 使用哈希集合即可
 * 时间复杂度：O(n)
 * 空间复杂度：O(n)
 *# 方法二（简单未实现）
 * 先排序，如果存在重复，那么相邻的数字必定相等
 */