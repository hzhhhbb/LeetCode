namespace LeetCode.Tests.BinarySearchTree
{
    using LeetCode.BinarySearchTree;
    using LeetCode.BinaryTree;

    using NUnit.Framework;

    [TestFixture()]
    public class BalancedBinaryTreeTests
    {
        [Test()]
        public void IsBalancedTest()
        {
            // balanced tree
            TreeNode root=new TreeNode(3);
            root.left=new TreeNode(9);
            root.right=new TreeNode(20);
            root.right.left=new TreeNode(15);
            root.right.right=new TreeNode(7);

            bool expected = true;
            bool isBalanced = new BalancedBinaryTree().IsBalanced(root);
            Assert.AreEqual(expected,isBalanced);
        }

        [Test()]
        public void IsBalancedTest1()
        {
            // not  balanced tree
            TreeNode root=new TreeNode(3);
            root.left=new TreeNode(9);
            root.right=new TreeNode(20);
            root.right.left=new TreeNode(15);
            root.right.right=new TreeNode(7);
            root.right.right.left=new TreeNode(1);
            root.right.right.left.left=new TreeNode(1);
            bool expected = false;
            bool isBalanced = new BalancedBinaryTree().IsBalanced(root);
            Assert.AreEqual(expected,isBalanced);
        }
    }
}