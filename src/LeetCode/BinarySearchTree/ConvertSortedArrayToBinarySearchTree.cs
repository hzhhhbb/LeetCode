using LeetCode.BinaryTree;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 108. 将有序数组转换为二叉搜索树
    /// </summary>
   public class ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums) 
        {
            if (nums.Length == 0)
            {
                return null;
            }

            if (nums.Length == 1)
            {
                return new TreeNode(nums[0]);
            }


            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = (left + right) / 2;
            TreeNode root=new TreeNode(nums[mid]);
            root.left = SortedArrayToBST(nums, left, mid-1);
            root.right = SortedArrayToBST(nums, mid + 1, right);
            return root;
        }

    }
}
