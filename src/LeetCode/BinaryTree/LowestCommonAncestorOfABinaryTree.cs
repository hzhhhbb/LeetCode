using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 236. 二叉树的最近公共祖先
    /// </summary>
    public class LowestCommonAncestorOfABinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return root;
            }

            Dictionary<int,TreeNode> childAndFather=new Dictionary<int, TreeNode>();
            Search(root,root.left);
            Search(root,root.right);
            void Search(TreeNode father, TreeNode childNode)
            {
                if (childAndFather.ContainsKey(p.val) && childAndFather.ContainsKey(q.val))
                {
                    return;
                }
                if (childNode != null && father != null)
                {
                    childAndFather.TryAdd(childNode.val,father);
                    Search(childNode,childNode.left);
                    Search(childNode,childNode.right);
                }
            }
            HashSet<int> pFather=new HashSet<int>();
            while (childAndFather.ContainsKey(p.val))
            {
                pFather.Add(p.val);
                p = childAndFather[p.val];
            }
            
            while (childAndFather.ContainsKey(q.val))
            {
                if (pFather.Contains(q.val))
                {
                    return q;
                }
                else
                {
                    q = childAndFather[q.val];
                }
            }

            return root;
        }
    }
}