using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 101. 对称二叉树
    /// </summary>
    public class SymmetricTree
    {
        private bool isSymmetric = true;

        // 递归解法
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            this.CheckSymmetric(root.left,root.right);

            return isSymmetric;
        }

        private void CheckSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return;
            }

            if (left?.val != right?.val)
            {
                this.isSymmetric = false;
                return;
            }

            this.CheckSymmetric(left.left,right.right);
            this.CheckSymmetric(left.right,right.left);
        }

        //迭代解法
        public bool IsSymmetricOfIteration(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            Dictionary<int, IList<int?>> result = new Dictionary<int, IList<int?>>();
            Tuple<int, TreeNode> zeroNode = new Tuple<int, TreeNode>(0, root);
            Queue<Tuple<int, TreeNode>> queue = new Queue<Tuple<int, TreeNode>>();
            queue.Enqueue(zeroNode);

            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (result.ContainsKey(node.Item1))
                {
                    if (node.Item2 == null)
                    {
                        result[node.Item1].Add(null);
                        continue;
                    }
                    else
                    {
                        result[node.Item1].Add(node.Item2.val);
                    }
                }
                else
                {
                    if (node.Item2 == null)
                    {
                        result.Add(node.Item1, new List<int?>() { null });
                        continue;
                    }
                    else
                    {
                        result.Add(node.Item1, new List<int?>() { node.Item2.val });
                    }
                }

                queue.Enqueue(new Tuple<int, TreeNode>(node.Item1 + 1, node.Item2.left));

                queue.Enqueue(new Tuple<int, TreeNode>(node.Item1 + 1, node.Item2.right));
            }

            foreach (KeyValuePair<int, IList<int?>> kv in result)
            {
                int end = kv.Value.Count-1;
                for (int start = 0; start < kv.Value.Count; start++)
                {
                    if (start >= end)
                    {
                        break;
                    }
                    if (kv.Value[start] != kv.Value[end])
                    {
                        return false;
                    }
                   
                    end--;
                }
            }

            return true;
        }


    }
}