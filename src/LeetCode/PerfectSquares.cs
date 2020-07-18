using System;
using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// 279.完全平方数
    /// </summary>
    public class PerfectSquares
    {
        public int NumSquares(int n)
        {
            if (this.IsFullSquareNumber(n))
            {
                return 1;
            }

            List<int> squareNumbers = new List<int>();
            for (int i = 1; i * i < n; i++)
            {
                squareNumbers.Add(i * i);
            }

            HashSet<int> queue = new HashSet<int>();
            queue.Add(n);

            int level = 0;
            while (queue.Count > 0)
            {
                level++;
                HashSet<int> nextQueue = new HashSet<int>();
                foreach (int remainder in queue)
                {
                    foreach (int square in squareNumbers)
                    {
                        if (remainder.Equals(square))
                        {
                            return level;
                        }
                        else if (remainder < square)
                        {
                            break;
                        }
                        else
                        {
                            nextQueue.Add(remainder - square);
                        }
                    }
                }

                queue = nextQueue;
            }

            return level;
        }

        private bool IsFullSquareNumber(int number)
        {
            double root = Math.Sqrt(number);
            if (((int) root).ToString() == root.ToString())
            {
                return true;
            }

            return false;
        }
    }
}