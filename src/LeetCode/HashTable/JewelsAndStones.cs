using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 771. 宝石与石头
    /// </summary>
   public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S) 
        {
            HashSet<char> jewels=new HashSet<char>(J.ToCharArray());
            int count = 0;
            foreach (char s in S)
            {
                if (jewels.Contains(s))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
