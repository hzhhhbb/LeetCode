using LeetCode.BinaryTree;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 450. 删除二叉搜索树中的节点
    /// </summary>
    public class DeleteNodeInABST
    {
        public int GetSuccessorValue(TreeNode root)
        {
            root = root.right;
            while (root.left != null)
            {
                root = root.left;
            }
            return root.val;
        }

        /*
        One step left and then always right
        */
        public int GetPredecessorValue(TreeNode root)
        {
            root = root.left;
            while (root.right != null)
            {
                root = root.right;
            }
            return root.val;
        }

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
            {
                return null;
            }

            // delete from the right subtree
            if (key > root.val)
            {
                root.right = DeleteNode(root.right, key);
            }
            // delete from the left subtree
            else if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            // delete the current node
            else
            {
                // the node is a leaf
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                // the node is not a leaf and has a right child
                else if (root.right != null)
                {
                    root.val = GetSuccessorValue(root);
                    root.right = DeleteNode(root.right, root.val);
                }
                // the node is not a leaf, has no right child, and has a left child    
                else
                {
                    root.val = GetPredecessorValue(root);
                    root.left = DeleteNode(root.left, root.val);
                }
            }

            return root;
        }
    }
}