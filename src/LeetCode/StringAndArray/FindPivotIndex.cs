using System.Linq;

namespace LeetCode.StringAndArray
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            if (!nums.Any())
            {
                return -1;
            }

            int sum = nums.Sum();
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum * 2 == sum - nums[i])
                {
                    return i;
                }

                leftSum += nums[i];
            }

            return -1;
        }
    }
}