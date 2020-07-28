using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 454. 四数相加 II
    /// </summary>
   public class FourSumII
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D) 
        {
            Dictionary<int,int> abSum=new Dictionary<int, int>();
            Dictionary<int,int> cdSum=new Dictionary<int, int>();

            foreach (int i in A)
            {
                foreach (int j in B)
                {
                    if (abSum.ContainsKey(i + j))
                    {
                        abSum[i + j]++;
                    }
                    else
                    {
                        abSum.Add(i+j,1);
                    }
                }
            }

            foreach (int i in C)
            {
                foreach (int j in D)
                {
                    if (cdSum.ContainsKey(i + j))
                    {
                        cdSum[i + j]++;
                    }
                    else
                    {
                        cdSum.Add(i+j,1);
                    }
                }
            }

            int count = 0;
            foreach (KeyValuePair<int, int> kv in abSum)
            {
                if (cdSum.ContainsKey(-kv.Key))
                {
                    count += kv.Value * cdSum[-kv.Key];
                }
            }

            return count;
        }
    }
}
