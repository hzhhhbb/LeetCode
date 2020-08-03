namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 167. 两数之和 II - 输入有序数组
    /// </summary>
    public class TwoSumIIInputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start < end)
            {
                int sum = numbers[start] + numbers[end];
                if (sum == target)
                {
                    return new int[2] { start + 1, end + 1 };
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return new int[2] { -1, -1 };
        }
    }
}