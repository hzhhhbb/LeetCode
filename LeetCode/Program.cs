using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           MyQueue queue=new MyQueue();
           queue.Push(1);
           queue.Push(2);
           Console.WriteLine("peek:{0}",queue.Peek());
           Console.WriteLine("pop:{0}",queue.Pop());
           Console.WriteLine("Empty:{0}",queue.Empty());
           Console.ReadKey();
        }
    }
}
