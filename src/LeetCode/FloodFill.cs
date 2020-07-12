using System;
using System.Collections.Generic;

namespace LeetCode
{
    using System.Linq;

    /// <summary>
    /// 733. 图像渲染
    /// </summary>
    public class FloodFillClass
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int originColor = image[sr][sc];
            Queue<Tuple<int, int>> node = new Queue<Tuple<int, int>>();

            node.Enqueue(new Tuple<int, int>(sr, sc));
            Dictionary<string,string> readNodeIndex=new Dictionary<string, string>();
            while (node.Any())
            {
                var tempNode = node.Dequeue();
                if (readNodeIndex.ContainsKey(string.Concat(tempNode.Item1, tempNode.Item2)))
                {
                    continue;
                }

                readNodeIndex.Add(string.Concat(tempNode.Item1,tempNode.Item2),string.Empty);

                if (tempNode.Item1 >= 0 && tempNode.Item1 < image.Length
                    && tempNode.Item2 >= 0 && tempNode.Item2 < image[0].Length
                    && image[tempNode.Item1][tempNode.Item2] == originColor)
                {
                    image[tempNode.Item1][tempNode.Item2] = newColor;
                    node.Enqueue(new Tuple<int, int>(tempNode.Item1 + 1, tempNode.Item2));
                    node.Enqueue(new Tuple<int, int>(tempNode.Item1 - 1, tempNode.Item2));
                    node.Enqueue(new Tuple<int, int>(tempNode.Item1, tempNode.Item2 + 1));
                    node.Enqueue(new Tuple<int, int>(tempNode.Item1, tempNode.Item2 - 1));
                }
            }

            return image;
        }
    }
}