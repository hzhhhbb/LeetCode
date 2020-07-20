using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 205. 同构字符串
    /// </summary>
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t) 
        {
            Dictionary<char,char> kv=new Dictionary<char,char>();
            Dictionary<char,char> kv1=new Dictionary<char,char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (kv.ContainsKey(s[i]))
                {
                    if (kv[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else if(kv1.ContainsKey(t[i]))
                {
                    if (kv1[t[i]]!=s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    kv.Add(s[i],t[i]);
                    kv1.Add(t[i],s[i]);
                }
            }

            return true;
        }
    }
}
