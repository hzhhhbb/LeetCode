using NUnit.Framework;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class PathSumTests
    {
        [Test()]
        public void HasPathSumTest()
        {
            TreeNode root=new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left=new TreeNode(11);
            root.left.left.left=new TreeNode(7);
            root.left.left.right=new TreeNode(2);

            root.right=new TreeNode(8);
            root.right.left=new TreeNode(13);
            root.right.right=new TreeNode(4);
            root.right.right.right=new TreeNode(1);

            bool expected = true;
            bool hasPath=new PathSum().HasPathSum(root,22);

            Assert.AreEqual(expected,hasPath);
        }

        [Test()]
        public void HasPathSumTest1()
        {
            TreeNode root = null;

            bool expected = false;
            bool hasPath=new PathSum().HasPathSum(root,22);

            Assert.AreEqual(expected,hasPath);
        }

        [Test()]
        public void HasPathSumOfIterationTest()
        {
            TreeNode root=new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left=new TreeNode(11);
            root.left.left.left=new TreeNode(7);
            root.left.left.right=new TreeNode(2);

            root.right=new TreeNode(8);
            root.right.left=new TreeNode(13);
            root.right.right=new TreeNode(4);
            root.right.right.right=new TreeNode(1);

            bool expected = true;
            bool hasPath=new PathSum().HasPathSumOfIteration(root,22);

            Assert.AreEqual(expected,hasPath);
        }

        [Test()]
        public void HasPathSumOfIterationTest1()
        {
            TreeNode root = null;

            bool expected = false;
            bool hasPath=new PathSum().HasPathSumOfIteration(root,22);

            Assert.AreEqual(expected,hasPath);
        }
    }
}