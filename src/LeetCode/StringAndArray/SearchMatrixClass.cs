using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 74. 搜索二维矩阵
    /// </summary>
    public class SearchMatrixClass
    {

        /*
         * 因为二位数据都是有序的，并且行有限，列很多
         * 第一步：先找到数据所在的行
         * 第二步：通过二分查找在行中查找目标值
         */

        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (!matrix.Any())
            {
                return false;
            }

            if (target < -10000 || target > 10000)
            {
                return false;
            }

            int lineNumber = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] > target)
                {
                    break;
                }

                lineNumber = i;
            }
            
            int left = 0;
            int right = matrix[lineNumber].Length-1;
            int mid = 0;

            while (left<=right)
            {
                mid = left + (right - left) / 2;
                if (matrix[lineNumber][mid] == target)
                {
                    return true;
                }

                if (matrix[lineNumber][mid] < target)
                {
                    left = mid+1;
                }
                else
                {
                    right = mid-1;
                }
            }

            return false;
        }
    }
}