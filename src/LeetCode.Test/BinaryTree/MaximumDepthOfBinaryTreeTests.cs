using NUnit.Framework;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class MaximumDepthOfBinaryTreeTests
    {
        [Test()]
        public void MaxDepthTest()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            int expected = 3;
            var maxDepth=new MaximumDepthOfBinaryTree().MaxDepth(root);

            Assert.AreEqual(expected,maxDepth);
        }

        [Test()]
        public void MaxDepthTest1()
        {
            TreeNode root = null;

            int expected = 0;
            var maxDepth = new MaximumDepthOfBinaryTree().MaxDepth(root);

            Assert.AreEqual(expected, maxDepth);
        }

        [Test()]
        public void MaxDepthTest2()
        {
            TreeNode root = new TreeNode(1);

            int expected = 1;
            var maxDepth = new MaximumDepthOfBinaryTree().MaxDepth(root);

            Assert.AreEqual(expected, maxDepth);
        }

        [Test()]
        public void MaxDepthTest3()
        {
            TreeNode root = new TreeNode(1);
            root.left=new TreeNode(1);
            root.left.left = new TreeNode(1);
            root.left.left.left = new TreeNode(1);
            root.left.left.left.left = new TreeNode(1);
            root.left.left.left.left.left = new TreeNode(1);
            root.left.left.left.left.left.left = new TreeNode(1);
            int expected = 7;
            var maxDepth = new MaximumDepthOfBinaryTree().MaxDepth(root);

            Assert.AreEqual(expected, maxDepth);
        }

        [Test()]
        public void MaxDepthTest4()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(1);
            root.left.left = new TreeNode(1);
            root.left.left.left = new TreeNode(1);
            root.left.left.left.left = new TreeNode(1);
            root.left.left.left.left.left = new TreeNode(1);
            root.left.left.left.left.left.left = new TreeNode(1);

            root.right = new TreeNode(1);
            root.right.right = new TreeNode(1);
            root.right.right.right = new TreeNode(1);
            root.right.right.right.right = new TreeNode(1);
            root.right.right.right.right.right = new TreeNode(1);
            root.right.right.right.right.right.right = new TreeNode(1);
            root.right.right.right.right.right.right.right = new TreeNode(1);

            int expected = 8;
            var maxDepth = new MaximumDepthOfBinaryTree().MaxDepth(root);

            Assert.AreEqual(expected, maxDepth);
        }
    }
}