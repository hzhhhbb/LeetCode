using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// 225. 用队列实现栈
    /// </summary>
    public class MyStack
    {
        private Queue<int> q1 = new Queue<int>();
        private Queue<int> q2 = new Queue<int>();

        /** Initialize your data structure here. */
        public MyStack()
        {
        }

        /** Push element x onto q1. */
        public void Push(int x)
        {
            q1.Enqueue(x);
        }

        /** Removes the element on top of the q1 and returns that element. */
        public int Pop()
        {
            int temp = 0;

            int stackCount = q1.Count;
            for (int i = 0; i < stackCount; i++)
            {
                if (i == stackCount - 1)
                {
                    temp = q1.Dequeue();
                    break;
                }

                q2.Enqueue(q1.Dequeue());
            }

            // 互换q1，q2,避免拷贝
            Queue<int> tempQueue = new Queue<int>();
            q1 = q2;
            q2 = tempQueue;

            return temp;
        }

        /** Get the top element. */
        public int Top()
        {
            int temp = 0;

            int stackCount = q1.Count;
            for (int i = 0; i < stackCount; i++)
            {
                temp = q1.Dequeue();
                q2.Enqueue(temp);
            }

            // 互换q1，q2,避免拷贝
            Queue<int> tempQueue = new Queue<int>();
            q1 = q2;
            q2 = tempQueue;

            return temp;
        }

        /** Returns whether the q1 is empty. */
        public bool Empty()
        {
            return !q1.Any();
        }
    }
}
/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */