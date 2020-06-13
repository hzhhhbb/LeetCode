namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 35. 搜索插入位置
    /// </summary>
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    return i;
                }
                else if (nums[i] > target)
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}