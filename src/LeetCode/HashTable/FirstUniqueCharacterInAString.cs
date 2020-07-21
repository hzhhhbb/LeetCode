using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 387. 字符串中的第一个唯一字符
    /// </summary>
   public class FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s) 
        {
            // 每个字符和它出现的次数、索引
            Dictionary<char,Tuple<int,int>> dic=new Dictionary<char,Tuple<int,int>>(s.Length);
         
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = new Tuple<int, int>(dic[s[i]].Item1+1,dic[s[i]].Item2);
                }
                else
                {
                    dic.Add(s[i],new Tuple<int, int>(1,i));
                }
            }

            foreach (KeyValuePair<char, Tuple<int,int>> kv in dic)
            {
                if (kv.Value.Item1 == 1)
                {
                    return kv.Value.Item2;
                }
            }

            return -1;
        }
    }
}
