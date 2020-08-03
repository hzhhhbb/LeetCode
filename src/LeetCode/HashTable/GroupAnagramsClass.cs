using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 49. 字母异位词分组
    /// </summary>
    public class GroupAnagramsClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
            {
                return new List<IList<string>>();
            }

            Dictionary<string, IList<string>> result = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                var s = str.ToCharArray();
                Array.Sort(s);
                string key = string.Join(string.Empty, s);
                if (result.ContainsKey(key))
                {
                    if (result[key] == null)
                    {
                        result[key] = new List<string>() { str };
                    }
                    else
                    {
                        result[key].Add(str);
                    }
                }
                else
                {
                    result.Add(key, new List<string>() { str });
                }
            }

            return result.Select(u => u.Value).ToList();
        }
    }
}