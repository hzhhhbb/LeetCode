using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 347. 前 K 个高频元素
    /// </summary>
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numberAndCount = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numberAndCount.ContainsKey(num))
                {
                    numberAndCount[num]++;
                }
                else
                {
                    numberAndCount.Add(num, 1);
                }
            }

            return numberAndCount.OrderByDescending(u => u.Value).Select(u => u.Key).Take(k).ToArray();
        }

        public int[] TopKFrequent1(int[] nums, int k)
        {
            return nums.GroupBy(u => u).ToDictionary(key => key.Key, value => value.Count()).OrderByDescending(u => u.Value).Select(u => u.Key).Take(k).ToArray();
        }
    }
}