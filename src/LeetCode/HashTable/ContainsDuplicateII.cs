using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 219. 存在重复元素 II
    /// </summary>
   public class ContainsDuplicateII
    {

        public bool ContainsNearbyDuplicate(int[] nums, int k) 
        {
            Dictionary<int,int> dic=new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                if (dic.ContainsKey(nums[index]))
                {
                    if (index - dic[nums[index]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dic[nums[index]] = index;
                    }
                }
                else
                {
                    dic.Add(nums[index],index);
                }
            }

            return false;
        }
    }
}
