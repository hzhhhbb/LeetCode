using System.Collections.Generic;
using System.Linq;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 面试题 01.08. 零矩阵
    /// </summary>
    public class ZeroMatrixLCCI
    {
        public void SetZeroes(int[][] matrix)
        {
            if (!matrix.Any())
            {
                return;
            }

            HashSet<int> rowNumbers = new HashSet<int>(matrix.Length);
            HashSet<int> columnNumbers = new HashSet<int>(matrix[0].Length);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j].Equals(0))
                    {
                        rowNumbers.Add(i);
                        columnNumbers.Add(j);
                    }
                }
            }

            foreach (int columnNumber in columnNumbers)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][columnNumber] = 0;
                }
            }

            foreach (int rowNumber in rowNumbers)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[rowNumber][i] = 0;
                }
            }
        }
    }
}
/*
 * 标记需要设置为0的行，列，再挨个设为0即可
 */