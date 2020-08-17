using LeetCode.BinaryTree;

namespace LeetCode.BinarySearchTree
{
   public class LowestCommonAncestorOfABinarySearchTree
    {
        /// <summary>
        /// 235. 二叉搜索树的最近公共祖先
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
        {
            TreeNode currentNode = root;
            while (currentNode!=null)
            {
                if (currentNode.val< p.val && currentNode.val <q.val)
                {
                    currentNode = currentNode.right;
                }
                else if(currentNode.val > p.val && currentNode.val >q.val)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    break;
                }
            }

            return currentNode;
        }
    }
}
