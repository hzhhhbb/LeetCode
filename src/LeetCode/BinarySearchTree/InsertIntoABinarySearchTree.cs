using System;
using LeetCode.BinaryTree;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 701. 二叉搜索树中的插入操作
    /// </summary>
   public class InsertIntoABinarySearchTree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                root=new TreeNode(val);
                return root;
            }

            TreeNode currentNode = root;
            while (currentNode!=null)
            {
                if (currentNode.val > val)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left=new TreeNode(val);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right=new TreeNode(val);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }

            }

            return root;
        }
    }
}
