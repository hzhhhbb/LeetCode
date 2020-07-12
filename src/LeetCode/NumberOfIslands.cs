using System;
using System.Collections.Generic;

namespace LeetCode
{
    using System.Linq;

    /// <summary>
    /// 200.岛屿数量
    /// </summary>
    public class NumberOfIslands
    {
        /// <summary>
        /// BFS
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int nr = grid.Length;
            int nc = grid[0].Length;

            int islandNum = 0;

            Queue<Tuple<int, int>> neighbors = new Queue<Tuple<int, int>>();
            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandNum++;

                        neighbors.Enqueue(new Tuple<int, int>(i, j));
                        while (neighbors.Any())
                        {
                            var item = neighbors.Dequeue();
                            if (item.Item1 >= 0 && item.Item1 < nr && item.Item2 >= 0 && item.Item2 < nc
                                && grid[item.Item1][item.Item2] == '1')
                            {
                                grid[item.Item1][item.Item2] = '0';

                                //上、下节点
                                neighbors.Enqueue(new Tuple<int, int>(item.Item1 + 1, item.Item2));
                                neighbors.Enqueue(new Tuple<int, int>(item.Item1 - 1, item.Item2));
                                //左、右节点
                                neighbors.Enqueue(new Tuple<int, int>(item.Item1, item.Item2 + 1));
                                neighbors.Enqueue(new Tuple<int, int>(item.Item1, item.Item2 - 1));
                            }
                        }
                    }
                }
            }

            return islandNum;
        }

        /// <summary>
        /// DFS
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslandsByDFS(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int nr = grid.Length;
            int nc = grid[0].Length;

            int islandNum = 0;

            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandNum++;

                        this.DFS(grid, i, j);
                    }
                }
            }

            return islandNum;
        }

        private void DFS(char[][] grid, int r, int c)
        {
            int nr = grid.Length;
            int nc = grid[0].Length;

            // 判断有效性
            if (r < 0 || c < 0 || r >= nr || c >= nc || grid[r][c] == '0')
            {
                return;
            }

            grid[r][c] = '0';
            DFS(grid,r-1,c);
            DFS(grid,r+1,c);
            DFS(grid,r,c-1);
            DFS(grid,r,c+1);

        }
    }

}

    /*
     * 给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。

岛屿总是被水包围，并且每座岛屿只能由水平方向或竖直方向上相邻的陆地连接形成。

此外，你可以假设该网格的四条边均被水包围。
 

示例 1:

输入:
11110
11010
11000
00000
输出: 1
示例 2:

输入:
11000
11000
00100
00011
输出: 3
解释: 每座岛屿只能由水平和/或竖直方向上相邻的陆地连接而成。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/number-of-islands
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
/*
 *# 200. 岛屿数量
 * ## 审题
 * 陆地是1，水是0，岛屿是单独的一个1，或者是1+1+1+1（相邻的1）。那么我们可以把1+1+1+1看成是整体的1。
 * 碰到一个1，就把它相邻的1全找出来，岛屿数量+1。为了防止重复计数，需要把已访问过的陆地做一下标记，比如把陆地“吞并沉没”，即标记为0
 * ## 实现思路
 * 遍历二维数组，访问到1时，岛屿数量+1，并启动广度、深度优先遍历，把遍历到的所有相邻的1标记为0
 */

