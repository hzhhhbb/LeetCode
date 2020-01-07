using System;

namespace LeetCode
{
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue circularQueue = new MyCircularQueue(6);
            Queue<int> queue = new Queue<int>(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.WriteLine("should be true,{0}",circularQueue.EnQueue(6)); 
            Console.WriteLine("should be 6,{0}", circularQueue.Rear());  
            Console.WriteLine("should be 6,{0}", circularQueue.Rear()); 
    
            Console.WriteLine("should be true,{0}", circularQueue.DeQueue());
            Console.WriteLine("should be true,{0}", circularQueue.EnQueue(5));
            Console.WriteLine("should be 5,{0}", circularQueue.Rear());
            Console.WriteLine("should be true,{0}", circularQueue.DeQueue());
            Console.WriteLine("should be -1,{0}",circularQueue.Front());
            Console.WriteLine("should be false,{0}", circularQueue.DeQueue());
            Console.WriteLine("should be false,{0}", circularQueue.DeQueue());
            Console.WriteLine("should be false,{0}", circularQueue.DeQueue());


            Console.ReadKey();
        }
    }
}
