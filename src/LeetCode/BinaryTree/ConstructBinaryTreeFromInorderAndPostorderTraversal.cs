using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 106. 从中序与后序遍历序列构造二叉树
    /// </summary>
   public class ConstructBinaryTreeFromInorderAndPostorderTraversal
    {
        private Dictionary<int, int> inorderIndexes;
        public TreeNode BuildTree(int[] inorder, int[] postorder) {
            if (inorder.Length == 0)
            {
                return null;
            }

            int nodeCount = inorder.Length;
            inorderIndexes=new Dictionary<int, int>(nodeCount);

            for (int i = 0; i < inorder.Length; i++)
            {
                inorderIndexes.Add(inorder[i],i);
            }

            return this.BuildTree(postorder, 0, nodeCount - 1, 0, nodeCount - 1);
        }


        private TreeNode BuildTree(int[] postorder, int postorderLeftIndex, int postorderRightIndex,
            int inorderLeftIndex, int inorderRightIndex)
        {
            if (postorderRightIndex < postorderLeftIndex)
            {
                return null;
            }

            int postorderRootIndex = postorderRightIndex;

            int inorderRootIndex = inorderIndexes[postorder[postorderRootIndex]];

            //右子树的节点数目
            int sizeOfRightSubtree = inorderRightIndex - inorderRootIndex;

            TreeNode root=new TreeNode(postorder[postorderRootIndex]);

            root.right = BuildTree(postorder, postorderRootIndex -sizeOfRightSubtree, postorderRootIndex - 1, inorderRootIndex + 1,
                inorderRightIndex);

            root.left = BuildTree(postorder,postorderLeftIndex, postorderRootIndex-1-sizeOfRightSubtree, inorderLeftIndex, inorderRootIndex-1);

            return root;
        }
    }
}
