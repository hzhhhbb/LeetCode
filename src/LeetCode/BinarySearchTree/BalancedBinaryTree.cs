namespace LeetCode.BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.BinaryTree;

    /// <summary>
    /// 110. 平衡二叉树
    /// </summary>
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            else
            {
                return Math.Abs(Height(root.left) - Height(root.right)) <= 1 && IsBalanced(root.left) &&
                       IsBalanced(root.right);
            }
        }

        //空节点高度为0，否则为1，递归求高度即可
        public int Height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(Height(root.left), Height(root.right)) + 1;
            }
        }
    }
}