using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.BinaryTree;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 173. 二叉搜索树迭代器
    /// </summary>
    public class BSTIterator
    {
        private List<int> inorder;
        private int currentIndex = 0;

        public BSTIterator(TreeNode root)
        {
            inorder = new List<int>();
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            while (stack.Any() || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();
                inorder.Add(curr.val);
                curr = curr.right;
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            if (HasNext())
            {
                currentIndex++;

                return inorder[currentIndex-1];
            }
            else
            {
                throw new ArgumentException("has not next value");
            }
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return currentIndex < inorder.Count;
        }
    }

    /// <summary>
    /// 173. 二叉搜索树迭代器 -受控的中序遍历
    /// </summary>
    public class BSTIteratorII
    {
        private Stack<TreeNode> stack = null;
        public BSTIteratorII(TreeNode root)
        {
            stack= new Stack<TreeNode>();

            this.AddLeftNodeToStack(root);
        }

        private void AddLeftNodeToStack(TreeNode node)
        {
            while (node != null)
            {
                this.stack.Push(node);
                node = node.left;
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode node = stack.Pop();
            if (node.right != null)
            {
                this.AddLeftNodeToStack(node.right);
            }

            return node.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return this.stack.Any();
        }
    }
}