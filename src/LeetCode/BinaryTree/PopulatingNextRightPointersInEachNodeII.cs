using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 117. 填充每个节点的下一个右侧节点指针 II
    /// </summary>
    public class PopulatingNextRightPointersInEachNodeII
    {
        // 广度遍历，空间、时间复杂度O(n)
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            // Initialize a queue data structure which contains
            // just the root of the tree
            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);

            // Outer while loop which iterates over 
            // each level
            while (Q.Any())
            {
                // Note the size of the queue
                int size = Q.Count;

                // Iterate over all the nodes on the current level
                for (int i = 0; i < size; i++)
                {
                    // Pop a node from the front of the queue
                    Node node = Q.Dequeue();

                    // This check is important. We don't want to
                    // establish any wrong connections. The queue will
                    // contain nodes from 2 levels at most at any
                    // point in time. This check ensures we only 
                    // don't establish next pointers beyond the end
                    // of a level
                    if (i < size - 1)
                    {
                        node.next = Q.Peek();
                    }

                    // Add the children, if any, to the back of
                    // the queue
                    if (node.left != null)
                    {
                        Q.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        Q.Enqueue(node.right);
                    }
                }
            }

            // Since the tree has now been modified, return the root node
            return root;
        }

        // 空间复杂度O(1)、时间复杂度O(N)
        public Node Connect1(Node root)
        {
            if (root == null)
            {
                return root;
            }

            Node farLeftNode = root;
            Node currNode = farLeftNode;


            Node prevNode = null;

            while (farLeftNode!=null)
            {
                prevNode = null;
                currNode = farLeftNode;
                farLeftNode = null;

                while (currNode!=null)
                {
                    ProcessChildNode(currNode.left);
                    ProcessChildNode(currNode.right);
                    currNode = currNode.next;
                }
            }

            void ProcessChildNode(Node childNode)
            {
                if (childNode != null)
                {
                    if (prevNode == null)
                    {
                        farLeftNode = childNode;
                    }
                    else
                    {
                        prevNode.next = childNode;
                    }

                    prevNode = childNode;
                }
            }

            return root;
        }
    }
}