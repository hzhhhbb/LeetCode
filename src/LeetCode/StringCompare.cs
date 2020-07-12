using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// 844. 比较含退格的字符串
    /// </summary>
   public class StringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            return this.Build(S).Equals(this.Build(T));
        }

        public string Build(string S)
        {
            Stack<char> s = new Stack<char>(S.Length);
          
            foreach (var t1 in S)
            {
                if (t1.Equals('#'))
                {
                    if (s.Count > 0)
                    {
                        s.Pop();
                    }
                }
                else
                {
                    s.Push(t1);
                }
            }
            
            return new string(s.ToArray());
        }
    }
}
