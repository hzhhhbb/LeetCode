using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    using System.Linq;

    /// <summary>
    /// 394. 字符串解码
    /// </summary>
    public class DecodeStringClass
    {
        public string DecodeString(string s)
        {
            Stack<char> stack=new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(']'))
                {
                    string tempStr = string.Empty;
                    while (stack.Peek()!='[')
                    {
                        tempStr = stack.Pop() + tempStr;
                    }

                    stack.Pop();
                    string numberStr = string.Empty;
                    while (stack.Any()&&char.IsDigit(stack.Peek()))
                    {
                        numberStr = stack.Pop() + numberStr;
                    }

                    if (!int.TryParse(numberStr, out int count))
                    {
                        count = 1;
                    }

                    for (int j = 0; j < count; j++)
                    {
                        foreach (char c in tempStr)
                        {
                            stack.Push(c);
                        }
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            StringBuilder result=new StringBuilder();
            while (stack.Any())
            {
                result.Append(stack.Pop());
            }

            return string.Concat(result.ToString().Reverse());
        }
    }
}
