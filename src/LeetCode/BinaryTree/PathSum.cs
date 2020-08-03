using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 112. 路径总和
    /// </summary>
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return sum == root.val;
            }

            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }

        public bool HasPathSumOfIteration(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            Queue<Tuple<TreeNode,int>> queue=new Queue<Tuple<TreeNode, int>>();
            queue.Enqueue(new Tuple<TreeNode, int>(root, root.val));
            while (queue.Any())
            {
                var currentNode = queue.Dequeue();
                if (currentNode.Item1.left == null && currentNode.Item1.right == null)
                {
                    if (sum == currentNode.Item2)
                    {
                        return true;
                    }
                }

                if (currentNode.Item1.left != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(currentNode.Item1.left,currentNode.Item1.left.val+currentNode.Item2));
                }
                if (currentNode.Item1.right != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(currentNode.Item1.right,currentNode.Item1.right.val+currentNode.Item2));
                }

            }

            return false;
        }
    }
}
/*
 * 解题思路：
 * 把大问题拆解为小问题
 * 如果二叉树只有123三个节点，那么问题就变成了12的和、13的和，也就是根节点到左右节点的和是否等于给定和。
 * 把当前节点的值和它的父节点的值加起来，就相当于是给定和。一直递归或者广度搜索即可
 */