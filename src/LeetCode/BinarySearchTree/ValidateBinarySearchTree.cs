using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinarySearchTree
{
    using LeetCode.BinaryTree;

    /// <summary>
    /// 98. 验证二叉搜索树
    /// </summary>
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            long prevValue = -long.MaxValue;
            while (stack.Any() || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();

                //二叉搜索树的中序遍历一定是升序的
                if (prevValue >= curr.val)
                {
                    return false;
                }
                else
                {
                    prevValue = curr.val;
                }
                curr = curr.right;
            }

            return true;
        }
    }
}