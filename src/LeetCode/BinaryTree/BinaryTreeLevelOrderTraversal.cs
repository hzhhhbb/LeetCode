using System;
using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    using System.Linq;

    /// <summary>
    /// 102. 二叉树的层序遍历
    /// </summary>
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            Dictionary<int, IList<int>> result = new Dictionary<int, IList<int>>();
            Tuple<int, TreeNode> zeroNode = new Tuple<int, TreeNode>(0, root);
            Queue<Tuple<int, TreeNode>> queue = new Queue<Tuple<int, TreeNode>>();
            queue.Enqueue(zeroNode);

            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (result.ContainsKey(node.Item1))
                {
                    result[node.Item1].Add(node.Item2.val);
                }
                else
                {
                    result.Add(node.Item1, new List<int>() { node.Item2.val });
                }

                if (node.Item2.left != null)
                {
                    queue.Enqueue(new Tuple<int, TreeNode>(node.Item1 + 1, node.Item2.left));
                }

                if (node.Item2.right != null)
                {
                    queue.Enqueue(new Tuple<int, TreeNode>(node.Item1 + 1, node.Item2.right));
                }
            }

            return result.Select(u => u.Value).ToList();
        }
    }
}