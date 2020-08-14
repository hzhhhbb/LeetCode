using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    using System.Linq;

    /// <summary>
    /// 297. 二叉树的序列化与反序列化
    /// </summary>
    public class SerializeAndDeserializeBinaryTree
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return string.Empty;
            }
            List<int?> treeList=new List<int?>();
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();
                if (node == null)
                {
                    treeList.Add(null);
                }
                else
                {
                    treeList.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }

            int i = treeList.Count - 1;
            for (; i >=0; i--)
            {
                if (treeList[i] != null)
                {
                    break;
                }
            }
            return string.Join(",", treeList.Take(i+1));
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            string[] treeNodes = data.Split(",");
            TreeNode root = null;
            if (int.TryParse(treeNodes[0], out int rootVal))
            {
                root=new TreeNode(rootVal);
            }
            else
            {
                return root;
            }

            Queue<TreeNode> queue=new Queue<TreeNode>(treeNodes.Length);
            queue.Enqueue(root);

            int currentLevelNodeCount = 1;
            int visitedNodeCount = 1;

            while (queue.Any())
            {
                int tempChildNodeCount = 0;
                for (int i = 0; i < currentLevelNodeCount; i++)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        if (visitedNodeCount<treeNodes.Length&&int.TryParse(treeNodes[visitedNodeCount], out int leftVal))
                        {
                            node.left = new TreeNode(leftVal);
                            queue.Enqueue(node.left);
                            tempChildNodeCount++;
                        }

                        visitedNodeCount++;
                        if (visitedNodeCount<treeNodes.Length&&int.TryParse(treeNodes[visitedNodeCount], out int rightVal))
                        {
                            node.right = new TreeNode(rightVal);
                            queue.Enqueue(node.right);
                            tempChildNodeCount++;
                        }
                        visitedNodeCount++;
                    }
                }

                currentLevelNodeCount = tempChildNodeCount;
            }

            return root;
        }
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));