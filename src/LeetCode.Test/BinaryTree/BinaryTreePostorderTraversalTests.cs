using System.Collections.Generic;
using LeetCode.BinaryTree;

using NUnit.Framework;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class BinaryTreePostorderTraversalTests
    {
        [Test()]
        public void PostorderTraversalTest()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            IList<int> expected = new List<int>() { 3, 2, 1 };
            var result = new BinaryTreePostorderTraversal().PostorderTraversal(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            IList<int> expected = new List<int>()
                                      {
                                          4,
                                          5,
                                          2,
                                          6,
                                          7,
                                          3,
                                          1
                                      };
            var result = new BinaryTreePostorderTraversal().PostorderTraversal(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalTest2()
        {
            TreeNode root = new TreeNode(1);

            IList<int> expected = new List<int>() { 1 };
            var result = new BinaryTreePostorderTraversal().PostorderTraversal(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalTest3()
        {
            TreeNode root = null;

            IList<int> expected = new List<int>() { };
            var result = new BinaryTreePostorderTraversal().PostorderTraversal(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalOfIeterationTest()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            IList<int> expected = new List<int>() { 3, 2, 1 };
            var result = new BinaryTreePostorderTraversal().PostorderTraversalOfIteration(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalOfIeterationTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            IList<int> expected = new List<int>()
                                      {
                                          4,
                                          5,
                                          2,
                                          6,
                                          7,
                                          3,
                                          1
                                      };
            var result = new BinaryTreePostorderTraversal().PostorderTraversalOfIteration(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalOfIeterationTest2()
        {
            TreeNode root = new TreeNode(1);

            IList<int> expected = new List<int>() { 1 };
            var result = new BinaryTreePostorderTraversal().PostorderTraversalOfIteration(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void PostorderTraversalOfIeterationTest3()
        {
            TreeNode root = null;

            IList<int> expected = new List<int>() { };
            var result = new BinaryTreePostorderTraversal().PostorderTraversalOfIteration(root);
            Assert.AreEqual(expected, result);
        }
    }
}