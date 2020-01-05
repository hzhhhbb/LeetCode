﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    using System.Collections;
    using System.Linq;
    using System.Net.Http.Headers;

    /// <summary>
    /// 224. 基本计算器
    /// </summary>
    public class SimpleCalculator
    {
        public int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();

            // sign 代表正负
            int sign = 1, res = 0;
            int length = s.Length;
            for (int i = 0; i < length; i++)
            { 
                char ch = s[i];
                if (char.IsDigit(ch))
                {
                    int cur = ch - '0';
                    while (i + 1 < length && char.IsDigit(s[i + 1]))
                    {
                        i++;
                        cur = cur * 10 + s[i] - '0';
                    }

                    res = res + sign * cur;
                }
                else if (ch == '+')
                {
                    sign = 1;
                }
                else if (ch == '-')
                {
                    sign = -1;
                }
                else if (ch == '(')
                {
                    stack.Push(res);
                    res = 0;
                    stack.Push(sign);
                    sign = 1;
                }
                else if (ch == ')')
                {
                    res = stack.Pop() * res + stack.Pop();
                }
            }

            return res;
        }
    }
}
