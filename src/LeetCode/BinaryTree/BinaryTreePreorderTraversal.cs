using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 144. 二叉树的前序遍历
    /// </summary>
    public class BinaryTreePreorderTraversal
    {
        // 递归算法
        public IList<int> PreorderTraversal(TreeNode root)
        {
            //遍历顺序：根节点、左节点、右节点
            var result = new List<int>();
            this.Preorder(root, ref result);
            return result;
        }

        private void Preorder(TreeNode root, ref List<int> result)
        {
            if (root != null)
            {
                result.Add(root.val);
                this.Preorder(root.left, ref result);
                this.Preorder(root.right, ref result);
            }
        }

        // 遍历算法
        public IList<int> PreorderTraversalOfIteration(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }
            Stack<TreeNode> stack=new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Any())
            {
                var node = stack.Pop();
                result.Add(node.val);
                if (node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }

            return result;
        }
    }
}