namespace LeetCode.StringAndArray
{
    using System.Linq;

    /// <summary>
    /// 557. 反转字符串中的单词 III
    /// </summary>
    public class ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(" ").Select(u=>string.Join("",u.Reverse())));
        }
    }
}
