using System.Collections.Generic;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 118. 杨辉三角 II
    /// </summary>
   public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> pascalsTriangle = new List<IList<int>>();

            int numRows = rowIndex+1;
            for (int i = 0; i < numRows; i++)
            {
                var tempItem=new List<int>(i+1);
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        tempItem.Add(1);
                    }
                    else
                    {
                        tempItem.Add(pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j]);
                    }
                }
                pascalsTriangle.Add(tempItem);
            }

            return pascalsTriangle[rowIndex];
        }
    }
}
