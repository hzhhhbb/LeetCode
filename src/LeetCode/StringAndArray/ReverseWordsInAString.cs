using System.Linq;

namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 151. 翻转字符串里的单词
    /// </summary>
   public class ReverseWordsInAString
    {
        public string ReverseWords(string s) 
        {
            return string.Join(" ", s.Split(" ").Reverse().Where(u=>!string.IsNullOrWhiteSpace(u)));
        }
    }
}
/*
 * 1、将字符串按空格分割成字符串数组
 * 2、反转字符串
 * 3、使用string.join拼接字符串
 */