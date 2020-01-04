using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 最小栈，题目155
    /// </summary>
   public class MinStack
    {
        private List<int> Items;
        
        private int itemCount;

        public MinStack()
        {
            this.Items = new List<int>();
            this.itemCount = 0;
        }

        public void Push(int x)
        {
            this.Items.Add(x);
            this.itemCount++;
        }

        public void Pop()
        {
            this.Items.RemoveAt(this.itemCount - 1);
            this.itemCount--;
        }

        public int Top()
        {
            return this.Items[this.itemCount - 1];
        }

        public int GetMin()
        {
            if (this.itemCount == 0)
            {
                throw new StackOverflowException();
            }

            int minItem = this.Items[0];
            for (int i = 1; i < this.itemCount; i++)
            {
                if (this.Items[i] < minItem)
                {
                    minItem = this.Items[i];
                }
            }

            return minItem;
        }
    }
}
