using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.BinaryTree
{
    public class BinaryTreePostorderTraversal
    {
        // 中序遍历顺序：左节点、根节点、右节点

        // 递归解法
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root != null)
            {
                this.Postorder(root, ref result);
            }

            return result;
        }

        private void Postorder(TreeNode root, ref List<int> result)
        {
            if (root.left != null)
            {
                this.Postorder(root.left, ref result);
            }

            if (root.right != null)
            {
                this.Postorder(root.right, ref result);
            }

            result.Add(root.val);
        }

        // 迭代解法
        public IList<int> PostorderTraversalOfIteration(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Any())
            {
                TreeNode node = stack.Pop();
                result.Add(node.val);

                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }

            result.Reverse();
            return result;
        }
    }
}
/*
 * 解题思路
 * 前序遍历顺序：根左右
 * 中序遍历顺序：左根右
 * 后序遍历顺序：左右根，反过来就是根右左
 * 调整一下前序遍历的顺序即可
 */