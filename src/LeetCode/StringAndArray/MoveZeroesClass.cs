namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 283. 移动零
    /// </summary>
    public class MoveZeroesClass
    {
        public void MoveZeroes(int[] nums)
        {
            int slowIndex = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    if (slowIndex != fast)
                    {
                        nums[slowIndex] = nums[fast] ^ nums[slowIndex];
                        nums[fast] = nums[fast] ^ nums[slowIndex];
                        nums[slowIndex] = nums[fast] ^ nums[slowIndex];
                    }

                    slowIndex++;
                }
            }
        }
    }
}
/*
 *双指针，当快指针遇到不为0的元素并且快慢指针不相等的情况下，调换快慢指针的元素，慢指针加1
 */