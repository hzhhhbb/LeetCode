using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            return numberAndCount.OrderByDescending(u=>u.Value).Select(u=>u.Key).Take(k).ToArray();
        }
    }
}