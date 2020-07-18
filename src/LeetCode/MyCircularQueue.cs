namespace LeetCode
{
    /// <summary>
    ///  622. 设计循环队列
    /// </summary>
    public class MyCircularQueue
    {
        private int[] queue;

        private int head = -1;

        private int tail = -1;

        private int count = 0;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            this.queue = new int[k];
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (this.IsFull())
            {
                return false;
            }

            if (this.IsEmpty())
            {
                this.head = this.tail = 0;
                this.queue[this.tail] = value;
                this.count++;
                return true;
            }

            if (this.tail + 1 == this.queue.Length)
            {
                this.tail = 0;
            }
            else
            {
                this.tail++;
            }

            this.queue[this.tail] = value;
            this.count++;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (this.IsEmpty())
            {
                return false;
            }

            if (this.head + 1 == this.queue.Length)
            {
                this.head = 0;
            }

            if (this.count == 1)
            {
                this.head = this.tail = -1;
            }
            else
            {
                this.head++;
            }

            this.count--;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (this.IsEmpty())
            {
                return -1;
            }

            return this.queue[this.head];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (this.IsEmpty())
            {
                return -1;
            }

            return this.queue[this.tail];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return this.count == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return this.count == this.queue.Length;
        }
    }
}