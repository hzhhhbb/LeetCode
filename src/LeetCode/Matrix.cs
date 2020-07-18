using System;
using System.Collections.Generic;

namespace LeetCode
{
    using System.Linq;

    /// <summary>
    /// 542. 01 矩阵
    /// </summary>
    public class Matrix
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            int rowLength = matrix.Length;
            int columnLength = matrix[0].Length;

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            Dictionary<string, int> readNode = new Dictionary<string, int>();

            var result = (int[][]) matrix.Clone();

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        continue;
                    }

                    queue.Enqueue(new Tuple<int, int>(i, j));
                    while (queue.Any())
                    {
                        var tempNode = queue.Dequeue();

                        if (tempNode.Item1 >= 0 && tempNode.Item1 < rowLength && tempNode.Item2 >= 0
                            && tempNode.Item2 < columnLength && matrix[tempNode.Item1][tempNode.Item2] == 0)
                        {
                            int distance = Math.Abs(tempNode.Item1 - i) + Math.Abs(tempNode.Item2 - j);
                            result[i][j] = distance;
                            readNode.Clear();
                            queue.Clear();
                            break;
                        }

                        if (readNode.ContainsKey(string.Concat(tempNode.Item1, tempNode.Item2)))
                        {
                            continue;
                        }

                        readNode.Add(string.Concat(tempNode.Item1, tempNode.Item2), 0);

                        queue.Enqueue(new Tuple<int, int>(tempNode.Item1 + 1, tempNode.Item2));
                        queue.Enqueue(new Tuple<int, int>(tempNode.Item1 - 1, tempNode.Item2));
                        queue.Enqueue(new Tuple<int, int>(tempNode.Item1, tempNode.Item2 + 1));
                        queue.Enqueue(new Tuple<int, int>(tempNode.Item1, tempNode.Item2 - 1));
                    }
                }
            }

            return matrix;
        }
    }
}
/*
 *广度优先搜索即可
 *
 */