using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 36. 有效的数独
    /// </summary>
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<char, List<Tuple<int, int>>> numIndexes = new Dictionary<char, List<Tuple<int, int>>>(board.Length);
            Dictionary<int, List<char>> areaNums = new Dictionary<int, List<char>>(board.Length);
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    char tempChar = board[i][j];
                    if (tempChar == '.')
                    {
                        continue;
                    }

                    if (numIndexes.ContainsKey(tempChar))
                    {
                        var tempList = numIndexes[tempChar];
                        if (tempList.FirstOrDefault(u => u.Item1 == i || u.Item2 == j) != null)
                        {
                            return false;
                        }

                        tempList.Add(new Tuple<int, int>(i, j));
                    }
                    else
                    {
                        numIndexes.Add(tempChar, new List<Tuple<int, int>>() { new Tuple<int, int>(i, j) });
                    }

                    int areaNo = this.GetAreaNo(i, j);
                    if (areaNums.ContainsKey(areaNo))
                    {
                        var tempList = areaNums[areaNo];
                        if (tempList.Contains(tempChar))
                        {
                            return false;
                        }

                        tempList.Add(tempChar);
                    }
                    else
                    {
                        areaNums.Add(areaNo, new List<char>() { tempChar });
                    }
                }
            }

            return true;
        }

        private int GetAreaNo(int rowIndex, int columnIndex)
        {
            return (rowIndex / 3) * 3 + columnIndex / 3;
        }
    }
}