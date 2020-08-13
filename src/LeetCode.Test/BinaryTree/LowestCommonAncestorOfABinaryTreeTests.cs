using NUnit.Framework;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class LowestCommonAncestorOfABinaryTreeTests
    {
        [Test()]
        public void LowestCommonAncestorTest()
        {
            TreeNode root=new TreeNode(3);
            root.left=new TreeNode(5);
            root.left.left=new TreeNode(6);
            root.left.right=new TreeNode(2);
            root.left.right.left=new TreeNode(7);
            root.left.right.right=new TreeNode(4);
            root.right = new TreeNode(1);
            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(8);

            int p = 5;
            int q = 1;
            int expected = 3;

            TreeNode result = new LowestCommonAncestorOfABinaryTree().LowestCommonAncestor(root, new TreeNode(p), new TreeNode(q));
            Assert.AreEqual(expected,result.val);
        }

        [Test()]
        public void LowestCommonAncestorTest1()
        {
            TreeNode root=new TreeNode(3);
            root.left=new TreeNode(5);
            root.left.left=new TreeNode(6);
            root.left.right=new TreeNode(2);
            root.left.right.left=new TreeNode(7);
            root.left.right.right=new TreeNode(4);
            root.right = new TreeNode(1);
            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(8);

            int p = 5;
            int q = 4;
            int expected = 5;

            TreeNode result = new LowestCommonAncestorOfABinaryTree().LowestCommonAncestor(root, new TreeNode(p), new TreeNode(q));
            Assert.AreEqual(expected,result.val);
        }

        [Test()]
        public void LowestCommonAncestorTest2()
        {
            TreeNode root=new TreeNode(-1);
            root.left=new TreeNode(0);
            root.left.left=new TreeNode(-2);
            root.left.right=new TreeNode(4);
            root.left.left.left=new TreeNode(8);
            root.right=new TreeNode(3);
            int p = 8;
            int q = 4;
            int expected = 0;

            TreeNode result = new LowestCommonAncestorOfABinaryTree().LowestCommonAncestor(root, new TreeNode(p), new TreeNode(q));
            Assert.AreEqual(expected,result.val);
        }
    }
}