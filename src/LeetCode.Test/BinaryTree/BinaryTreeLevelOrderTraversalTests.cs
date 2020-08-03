using System;
using System.Collections.Generic;
using System.Text;

using LeetCode.BinaryTree;

using NUnit.Framework;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class BinaryTreeLevelOrderTraversalTests
    {
        [Test()]
        public void LevelOrderTest()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            IList<IList<int>> expected = new List<IList<int>>() { new List<int>() { 3 }, new List<int>() { 9, 20 }, new List<int>() { 15, 7 }, };

            var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void LevelOrderTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            IList<IList<int>> expected = new List<IList<int>>() { new List<int>() { 1 }, new List<int>() { 2, 3 }, new List<int>() { 4, 5, 6, 7 }, };

            var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
            Assert.AreEqual(expected, result);
        }
    }
}