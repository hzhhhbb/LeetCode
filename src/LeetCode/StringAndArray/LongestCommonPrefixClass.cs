using System.Collections.Generic;
using System.Linq;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 14. 最长公共前缀
    /// </summary>
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] strs) 
        {
            if (!strs.Any())
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            List<char> chars=new List<char>();
            
            for (int columnIndex = 0; columnIndex < strs[0].Length; columnIndex++)
            {
                char tempStr = strs[0][columnIndex];
                for (int rowIndex = 1; rowIndex < strs.Length; rowIndex++)
                {
                    if (strs[rowIndex].Length-1 < columnIndex)
                    {
                        return string.Join("", chars);
                    }
                    if(!tempStr.Equals(strs[rowIndex][columnIndex]))
                    {
                        return string.Join("", chars);
                    }
                }

                chars.Add(tempStr);
            }

            return string.Join("", chars);
        }
    }
}
/*
 * 可以把字符串数据看出是M*N的字符矩阵，纵向扫描矩阵即可
 * 注意字符串长度不是一样的，所以需要防止在访问数组时越界
 */