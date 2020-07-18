using System.Collections.Generic;

namespace LeetCode
{
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
                    int tempSign = stack.Pop();
                    int tempRes = stack.Pop();
                    res = tempRes + (res * tempSign);
                }
            }

            return res;
        }
    }
}