using System;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 104. 二叉树的最大深度
    /// </summary>
    public class MaximumDepthOfBinaryTree
    {
        private int maxDepth = 0;
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            this.GetMaxDepthOfBinaryTree(root,1);
            return maxDepth;
        }

        private void GetMaxDepthOfBinaryTree(TreeNode node,int depth)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                this.maxDepth = Math.Max(this.maxDepth, depth);
            }

            this.GetMaxDepthOfBinaryTree(node.left, depth + 1);
            this.GetMaxDepthOfBinaryTree(node.right, depth + 1);
        }
    }
}
