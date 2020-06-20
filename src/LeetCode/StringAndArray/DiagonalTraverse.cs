using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 498. 对角线遍历
    /// </summary>
    public class DiagonalTraverse
    {
        public int[] FindDiagonalOrder(int[][] matrix) 
        {
            if (!matrix.Any())
            {
                return new int[0];
            }

            List<int> result=new List<int>(matrix.Length * matrix[0].Length);
            int rowMaxIndex = matrix.Length-1;
            int columnMaxIndex= matrix[0].Length-1;

            //指向为右上方为正向
            bool isPositive = true;
            int count = 0;
            int matrixCount = matrix.Length * matrix[0].Length;
            Tuple<int,int> nodeIndex=new Tuple<int, int>(0,0);

            while (count < matrixCount)
            {
                //正向遍历
                if (isPositive)
                {
                    if (nodeIndex.Item1 < 0&&nodeIndex.Item2<=columnMaxIndex)
                    {
                        nodeIndex=new Tuple<int, int>(nodeIndex.Item1 + 1,nodeIndex.Item2);
                        isPositive = false;
                        continue;
                    }
                    else if (nodeIndex.Item2 > columnMaxIndex)
                    {
                        nodeIndex=new Tuple<int, int>(nodeIndex.Item1 + 2,nodeIndex.Item2 - 1);
                        isPositive = false;
                        continue;
                    }

                    result.Add(matrix[nodeIndex.Item1][nodeIndex.Item2]);
                    nodeIndex=new Tuple<int, int>(nodeIndex.Item1-1,nodeIndex.Item2+1);
                }
                else //反向遍历
                {
                    if (nodeIndex.Item2 < 0&&nodeIndex.Item1<=rowMaxIndex)
                    {
                        nodeIndex=new Tuple<int, int>(nodeIndex.Item1,nodeIndex.Item2+1);
                        isPositive = true;
                        continue;
                    }
                    else if(nodeIndex.Item1 > rowMaxIndex)
                    {
                        nodeIndex = new Tuple<int, int>(nodeIndex.Item1 -1 ,nodeIndex.Item2+2);
                        isPositive = true;
                        continue;
                    }

                    result.Add(matrix[nodeIndex.Item1][nodeIndex.Item2]);
                    nodeIndex=new Tuple<int, int>(nodeIndex.Item1+1,nodeIndex.Item2-1);
                }

                count++;
            }

            return result.ToArray();
        }
    }
}

/*
 * 平常的二维数据是从左往右，从上到下遍历，到达某行顶点就开始下一行的遍历
 * 对角线遍历也类似，从左下到右上、右上到左下，到达右上顶点、左下顶点就开始下一轮遍历即可
 */