using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 232. 用栈实现队列
    /// </summary>
    public class MyQueue
    {
       private Stack<int> Queue;

       private Stack<int> tempStack;

        /** Initialize your data structure here. */
        public MyQueue()
        {
            this.Queue=new Stack<int>();
            this.tempStack=new Stack<int>();
        }

        /** Push element x to the back of Queue. */
        public void Push(int x)
        {
            if (this.Queue.Count == 0)
            {
                this.Queue.Push(x);
            }
            else
            {

                while (this.Queue.Count != 0)
                {
                   this.tempStack.Push(this.Queue.Pop());
                }
                this.tempStack.Push(x);

                while (this.tempStack.Count != 0)
                {
                    this.Queue.Push(this.tempStack.Pop());
                }
            }
        }

        /** Removes the element from in front of Queue and returns that element. */
        public int Pop()
        {
            return this.Queue.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return this.Queue.Peek();
        }

        /** Returns whether the Queue is empty. */
        public bool Empty()
        {
            return this.Queue.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
