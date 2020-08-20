using System.Collections.Generic;
using System.Linq;

namespace LeetCode.NAryTree
{
    /// <summary>
    /// 590. N叉树的后序遍历
    /// </summary>
   public class NAryTreePostorderTraversal
    {
        //递归法
        public IList<int> Postorder(Node root) 
        {
            List<int> result=new List<int>();
            if (root == null)
            {
                return result;
            }

            if (root.children != null && root.children.Any())
            {
                foreach (Node node in root.children)
                {
                    result.AddRange(this.Postorder(node));
                }
            }
            result.Add(root.val);
            return result;
        }

        //迭代法
        public IList<int> Postorder1(Node root) 
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
                    for (int i = 0; i <node.children.Count; i++)
                    {
                        stack.Push(node.children[i]);
                    }
                }
            }

            result.Reverse();
            return result;
        }
    }
}
