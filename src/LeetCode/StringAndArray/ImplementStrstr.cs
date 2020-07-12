namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 28. 实现 strStr()
    /// </summary>
   public class ImplementStrstr
    {
        public int StrStr(string haystack, string needle) 
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            int result = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int startIndex = i+1;
                    int needleIndex = 1;

                    while (startIndex<haystack.Length&&needleIndex<needle.Length)
                    {
                        if (haystack[startIndex] == needle[needleIndex])
                        {
                            startIndex++;
                            needleIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (needleIndex==needle.Length)
                    {
                        result=i;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
