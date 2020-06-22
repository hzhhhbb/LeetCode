using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 344. 反转字符串
    /// </summary>
   public class ReverseStringClass
    {
        public void ReverseString(char[] s)
        {
            if (s == null)
            {
                return;
            }

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                s[start] = (char)(s[start] ^ s[end]);
                s[end] = (char)(s[start] ^ s[end]);
                s[start] = (char)(s[start] ^ s[end]);

                start++;
                end--;
            }
        }
    }
}
/*
 * 双指针，通过位异或运算实现原地交换（题目中限定数组中的所有字符都是 ASCII 码表中的可打印字符）
 */