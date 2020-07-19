using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 202. 快乐数
    /// </summary>
   public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> visited=new HashSet<int>();
            visited.Add(n);
            while (n!=1)
            {
                n= this.GetNextNumber(n);
                if (visited.Contains(n))
                {
                    return false;
                }
                else
                {
                    visited.Add(n);
                }
            }

            return true;
        }

        private int GetNextNumber(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int d = n % 10;
                n = n / 10;
                sum += d * d;
            }

            return sum;
        }
    }
}
/*
 * 用哈希表存储已经遍历过的数，来确定是否进入无限循环
 */
