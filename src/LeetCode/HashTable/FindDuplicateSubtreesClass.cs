using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 652. 寻找重复的子树
    /// </summary>
    public class FindDuplicateSubtreesClass
    {
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            Dictionary<string,TreeNode> dic=new Dictionary<string, TreeNode>();
            Dictionary<string,TreeNode> result=new Dictionary<string, TreeNode>();
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var tempNode = queue.Dequeue();
                if (tempNode != null)
                {
                    string uId = GetUId(tempNode);
                    if (!dic.TryAdd(uId, tempNode))
                    {
                        result.TryAdd(uId,tempNode);
                    }

                    if (tempNode.left != null)
                    {
                        queue.Enqueue(tempNode.left);
                    }
                    if (tempNode.right != null)
                    {
                        queue.Enqueue(tempNode.right);
                    }
                }
            }

            return result.Select(u => u.Value).ToList();
        }

        private string GetUId(TreeNode root)
        {
            StringBuilder sb=new StringBuilder();

            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var tempNode = queue.Dequeue();
                if (tempNode != null)
                { 
                    sb.Append(tempNode.val);
                    if (tempNode.left != null)
                    {
                        queue.Enqueue(tempNode.left);
                    }
                    else
                    {
                        sb.Append("*");
                    }
                    if (tempNode.right != null)
                    {
                        queue.Enqueue(tempNode.right);
                    }
                    else
                    {
                        sb.Append("#");
                    }
                }
            }

            return sb.ToString();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static class TreeNodeExtension
    {
        public static bool IsEqual(this TreeNode root, TreeNode other)
        {
            var list1 = GetTreeNodes(root);
            var list2 = GetTreeNodes(other);

            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[1] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static List<TreeNode> GetTreeNodes(TreeNode root)
        {
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var tempNode = queue.Dequeue();
                if (tempNode != null)
                {
                    if (tempNode.left != null)
                    {
                        queue.Enqueue(tempNode.left);
                    }
                    if (tempNode.right != null)
                    {
                        queue.Enqueue(tempNode.right);
                    }
                }
            }

            return queue.ToList();
        }
    }
}