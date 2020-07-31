using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 94. 二叉树的中序遍历
    /// </summary>
    public class BinaryTreeInorderTraversal
    {
        //中序遍历顺序：左节点、根节点、右节点

        // 递归算法
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root != null)
            {
                this.Inorder(root, ref result);
            }

            return result;
        }

        private void Inorder(TreeNode root, ref List<int> result)
        {
            if (root.left != null)
            {
                this.Inorder(root.left, ref result);
            }

            result.Add(root.val);

            if (root.right != null)
            {
                this.Inorder(root.right, ref result);
            }
        }


        // 迭代算法
        public IList<int> InorderTraversalOfIteration(TreeNode root)
        {
            List<int> result=new List<int>();
            if (root == null)
            {
                return result;
            }

            Stack<TreeNode> stack=new Stack<TreeNode>();
            TreeNode curr = root;
            while (stack.Any()||curr!=null)
            {
                while (curr!=null)
                {
                   stack.Push(curr);
                   curr = curr.left;
                }

                curr = stack.Pop();
                result.Add(curr.val);
                curr = curr.right;

            }

            return result;
        }
    }
}