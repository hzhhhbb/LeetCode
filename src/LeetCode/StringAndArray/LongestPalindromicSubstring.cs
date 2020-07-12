using System;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 5. 最长回文子串
    /// </summary>
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length < 1)
            {
                return "";
            }

            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = this.ExpandAroundCenter(s, i, i);
                int len2 = this.ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > endIndex - startIndex) 
                {
                    startIndex = i - (len - 1) / 2;
                    endIndex = i + len / 2;
                }
            }

            return s.Substring(startIndex, endIndex-startIndex+1);
        }

        /// <summary>
        /// 中心扩展
        /// </summary>
        /// <param name="s"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int ExpandAroundCenter(string s, int left, int right)
        {
            int leftIndex = left;
            int rightIndex = right;
            while (leftIndex >= 0 && rightIndex <s.Length && s[leftIndex]==s[rightIndex])
            {
                leftIndex--;
                rightIndex++;
            }

            //跳出循环时，刚好满足s[leftIndex]!=s[rightIndex],
            //回文串的长度为rightIndex - leftIndex + 1 -2= j - i - 1
            // babad b为中心开始扩展，跳出循环时，左右下标分别为0、4，回文串aba长度为4 - 0 - 1
            return rightIndex - leftIndex - 1;
        }
    }
}
/*
 * 中心扩展法
 * 从字符串一个（两个）index开始，往左右扩展，直到不能扩展为止。重复这个动作直到找到最长的回文子串
 */