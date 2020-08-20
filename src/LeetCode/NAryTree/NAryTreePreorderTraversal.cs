using System.Collections.Generic;
using System.Linq;

namespace LeetCode.NAryTree
{
    /// <summary>
    /// 589. N叉树的前序遍历
    /// </summary>
    public class NAryTreePreorderTraversal
    {
        //递归法
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }

            result.Add(root.val);

            if (root.children != null && root.children.Any())
            {
                foreach (Node node in root.children)
                {
                    result.AddRange(this.Preorder(node));
                }
            }

            return result;
        }

        //迭代法
        public IList<int> Preorder1(Node root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Any())
            {
                var node = stack.Pop();
                result.Add(node.val);
                if (node.children != null && node.children.Any())
                {
                    for (int i = node.children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(node.children[i]);
                    }
                }
            }

            return result;
        }
    }
}