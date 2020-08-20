using System.Collections.Generic;
using System.Linq;

namespace LeetCode.NAryTree
{
    /// <summary>
    /// 429. N叉树的层序遍历
    /// </summary>
    public class NAryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result=new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<Node> queue=new Queue<Node>();
            queue.Enqueue(root);
          
            while (queue.Any())
            {
                int count = queue.Count;
                IList<int> levelNode=new List<int>(count);
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    levelNode.Add(node.val);
                    if (node.children != null)
                    {
                        foreach (Node child in node.children)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }

                result.Add(levelNode);
            }

            return result;
        }
    }
}