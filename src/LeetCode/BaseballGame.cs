using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// 682. 棒球比赛
    /// </summary>
    public class BaseballGame
    {
        public int CalPoints(string[] ops)
        {
            Stack<int> stack = new Stack<int>(ops.Length);

            foreach (string s in ops)
            {
                if (int.TryParse(s, out int result))
                {
                    stack.Push(result);
                }
                else if(s.Equals("+"))
                {
                    int top = stack.Pop();
                    int newTop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newTop);
                }
                else if (s.Equals("D"))
                {
                    stack.Push(stack.Peek() * 2);
                }
                else if (s.Equals("C"))
                {
                    stack.Pop();
                }
            }

            int count = 0;
            while (stack.Count > 0)
            {
                count += stack.Pop();
            }

            return count;
        }
    }
}
