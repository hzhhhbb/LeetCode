using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.NAryTree
{
    /// <summary>
    /// 559. N叉树的最大深度
    /// </summary>
    public class MaximumDepthOfNAryTree
    {
        public int MaxDepth(Node root) 
        {
            if (root == null)
            {
                return 0;
            }

            int depth = 0;
           
            Queue<Node> queue=new Queue<Node>();
            queue.Enqueue(root);
          
            while (queue.Any())
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node.children != null)
                    {
                        foreach (Node child in node.children)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }

                depth++;
            }

            return depth;
        }
    }
}