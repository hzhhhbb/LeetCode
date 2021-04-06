namespace LeetCode.StringAndArray
{
    /// <summary>
    ///     80. 删除有序数组中的重复项 II
    /// </summary>
    public class RemoveDuplicatesClass
    {
        public int RemoveDuplicates(int[] nums)
        {
            // 会修改原数据，不原样保留原数据
            if (nums.Length < 3)
            {
                return nums.Length;
            }

            int slow = 2, fast = 2;
            while (fast < nums.Length)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    ++slow;
                }

                ++fast;
            }

            return slow;
        }
    }
}