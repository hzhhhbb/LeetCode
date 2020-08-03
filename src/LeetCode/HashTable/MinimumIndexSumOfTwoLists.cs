using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 599. 两个列表的最小索引总和
    /// </summary>
    public class MinimumIndexSumOfTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            if (!list1.Any() || !list2.Any())
            {
                return new string[] { };
            }

            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                dic.TryAdd(list1[i], i);
            }

            Dictionary<string, int> resultDic = new Dictionary<string, int>();

            for (var index = 0; index < list2.Length; index++)
            {
                string s = list2[index];
                if (dic.ContainsKey(s))
                {
                    resultDic.TryAdd(s, index + dic[s]);
                }
            }

            List<string> result = new List<string>(list1.Length);
            var minResult = resultDic.Min(u => u.Value);
            foreach (KeyValuePair<string, int> kv in resultDic)
            {
                if (kv.Value == minResult)
                {
                    result.Add(kv.Key);
                }
            }

            return result.ToArray();
        }
    }
}