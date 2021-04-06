using System;
using System.Collections.Generic;

namespace LeetCode.Stack
{
    /// <summary>
    /// 1006. 笨阶乘
    /// </summary>
    public class ClumsyClass
    {
        public int Clumsy(int N)
        {
            /*
             * 先算乘除的结果，遇到加减符号就把数字和操作符压栈
             * 栈中只有数字和加减符号时，逐个出栈相加即可（减法=加数字的负数）
             */
            List<string> operators=new List<string>(){"*","/","+","-"};
            int operIndex = 0;
            Stack<string> stack=new Stack<string>();

            for (int left = N; left > 0; left--)
            {
                string oper = operators[operIndex];
                operIndex = operIndex + 1 > 3 ? 0 : operIndex + 1;
                if (stack.Count == 0)
                {
                    stack.Push(left.ToString());
                    stack.Push(oper);
                }
                else
                {
                    if (stack.Peek()=="*")
                    {
                        stack.Pop();
                        stack.Push((Convert.ToInt32(stack.Pop()) * left).ToString());
                        stack.Push(oper);
                    }
                    else if (stack.Peek()=="/")
                    {
                        stack.Pop();
                        stack.Push((Convert.ToInt32(stack.Pop()) / left).ToString());
                        stack.Push(oper);
                    }
                    else if (stack.Peek()=="+"||stack.Peek()=="-")
                    {
                        stack.Push(left.ToString());
                        stack.Push(oper);
                    }
                }
            }

            int result = 0;
            int cur = 0;
            while (stack.Count>0)
            {
                string curItem = stack.Pop();
                if (!operators.Contains(curItem))
                {
                    cur = Convert.ToInt32(curItem);
                    continue;
                }
                if(curItem=="-")
                {
                    cur = cur * -1;
                }
                result = result + cur;
            }

            return result+cur;
        }
    }
}
