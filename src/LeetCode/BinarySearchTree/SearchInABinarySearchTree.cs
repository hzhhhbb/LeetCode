using LeetCode.BinaryTree;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 700. 二叉搜索树中的搜索
    /// </summary>
   public class SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode currentNode = root;
            while (currentNode!=null)
            {
                if (currentNode.val == val)
                {
                    return currentNode;
                }

                currentNode = val < currentNode.val ? currentNode.left : currentNode.right;
            }

            return null;
        }
    }
}
