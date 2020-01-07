using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    using System.Linq;

    /// <summary>
    /// 346. 数据流中的移动平均值
    /// </summary>
    public class MovingAverage
    {
        private Queue<int> Queue;

        private int Size;
        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            this.Queue = new Queue<int>(size);
            this.Size = size;
        }

        public double Next(int val)
        {
            if (this.Queue.Count == this.Size)
            {
                this.Queue.Dequeue();
            }
            this.Queue.Enqueue(val);
            return this.Queue.Average();
        }
    }
}
