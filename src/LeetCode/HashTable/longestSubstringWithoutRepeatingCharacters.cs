using System;
using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 3. 无重复字符的最长子串
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return s.Length;
            }

            int tempLongestLength = 0;
            int longestLength = 0;
            Dictionary<char, int> charLastIndexes = new Dictionary<char, int>();
            for (var index = 0; index < s.Length; index++)
            {
                char c = s[index];
                if (charLastIndexes.ContainsKey(c))
                {
                    longestLength = Math.Max(tempLongestLength, longestLength);
                    tempLongestLength = Math.Min(index - charLastIndexes[c], tempLongestLength + 1);
                    charLastIndexes[c] = index;
                }
                else
                {
                    charLastIndexes.Add(c, index);
                    tempLongestLength++;
                }
            }

            longestLength = Math.Max(tempLongestLength, longestLength);
            return longestLength;
        }
    }
}
/* 方法一：
 * 用字典记录重复字符的最近位置，算出下一次迭代的初始长度。如果初始长度大于已有的长度，说明字符中间有重叠的字符，类似“caac”这样的，那么初始长度+1即可
 *
 * 方法二：队列
 * 迭代字符串，遇到重复字符，把队头出队，记录每次的长度，返回最大长度即可
 */