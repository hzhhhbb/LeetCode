using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue circularQueue = new MyCircularQueue(6); 

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
