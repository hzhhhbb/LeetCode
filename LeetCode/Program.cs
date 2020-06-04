using System;

namespace LeetCode
{
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            #region 622. 设计循环队列

            // {
            //     MyCircularQueue circularQueue = new MyCircularQueue(6);
            //     Queue<int> queue = new Queue<int>(4);
            //     queue.Enqueue(1);
            //     queue.Enqueue(2);
            //     queue.Enqueue(3);
            //
            //     foreach (int item in queue)
            //     {
            //         Console.WriteLine(item);
            //     }
            //
            //     Console.ReadKey();
            //     Console.WriteLine("should be true,{0}", circularQueue.EnQueue(6));
            //     Console.WriteLine("should be 6,{0}", circularQueue.Rear());
            //     Console.WriteLine("should be 6,{0}", circularQueue.Rear());
            //
            //     Console.WriteLine("should be true,{0}", circularQueue.DeQueue());
            //     Console.WriteLine("should be true,{0}", circularQueue.EnQueue(5));
            //     Console.WriteLine("should be 5,{0}", circularQueue.Rear());
            //     Console.WriteLine("should be true,{0}", circularQueue.DeQueue());
            //     Console.WriteLine("should be -1,{0}", circularQueue.Front());
            //     Console.WriteLine("should be false,{0}", circularQueue.DeQueue());
            //     Console.WriteLine("should be false,{0}", circularQueue.DeQueue());
            //     Console.WriteLine("should be false,{0}", circularQueue.DeQueue());
            // }

            #endregion

            #region 200. 岛屿数量

            // {
            //     char[][] grid = new char[][]
            //                         {
            //                             new char[5] { '1', '1', '0', '0', '0' },
            //                             new char[5] { '1', '1', '0', '0', '0' },
            //                             new char[5] { '0', '0', '1', '0', '0' },
            //                             new char[5] { '0', '0', '0', '1', '1' },
            //                         };
            //     Console.WriteLine(new NumberOfIslands().NumIslands(grid));
            // }

            #endregion

            #region 752. 打开转盘锁

            // {
            //     string[] deadends={"8887","8889","8878","8898","8788","8988","7888","9888"};
            //     string target = "8888";
            //     Console.WriteLine(new OpenLockClass().OpenLock(deadends,target));
            //
            // }

            #endregion

            Console.ReadKey();
        }
    }
}
