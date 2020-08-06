using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    /// <summary>
    ///     105. 从前序与中序遍历序列构造二叉树
    /// </summary>
    public class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        private Dictionary<int, int> indexDic;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int treeCount = preorder.Length;
            indexDic=new Dictionary<int, int>(treeCount);

            for (int i = 0; i < preorder.Length; i++)
            {
                indexDic.Add(inorder[i],i);
            }

            return this.Build(preorder, 0, treeCount - 1, 0, treeCount - 1);
        }

        private TreeNode Build(int[] preorder, int preorderLeftIndex, int preorderRightIndex, int inorderLeftIndex,
            int inorderRightIndex)
        {
            if (preorderLeftIndex > preorderRightIndex) {
                return null;
            }

            // 前序遍历中的第一个节点就是根节点下标
            int preorderRootIndex = preorderLeftIndex;

            // 在中序遍历中定位根节点下标
            int inorderRootIndex = indexDic[(preorder[preorderRootIndex])];
        
            // 先把根节点建立出来
            TreeNode root = new TreeNode(preorder[preorderRootIndex]);

            // 得到左子树中的节点数目
            int sizeOfLeftSubtree = inorderRootIndex - inorderLeftIndex;

            // 递归地构造左子树，并连接到根节点
            // 先序遍历中「从 左边界+1 开始的 size_left_subtree」个元素就对应了中序遍历中「从 左边界 开始到 根节点定位-1」的元素
            root.left = Build(preorder,  preorderLeftIndex + 1, preorderLeftIndex + sizeOfLeftSubtree, inorderLeftIndex, inorderRootIndex - 1);

            // 递归地构造右子树，并连接到根节点
            // 先序遍历中「从 左边界+1+左子树节点数目 开始到 右边界」的元素就对应了中序遍历中「从 根节点定位+1 到 右边界」的元素
            root.right = Build(preorder, preorderLeftIndex + sizeOfLeftSubtree + 1, preorderRightIndex, inorderRootIndex + 1, inorderRightIndex);

            return root;
        }
    }
}