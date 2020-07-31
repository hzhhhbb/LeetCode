using System.Collections.Generic;
using LeetCode.BinaryTree;
using NUnit.Framework;


namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class BinaryTreePreorderTraversalTests
    {
        [Test()]
        public void PreorderTraversalTest()
        {
            TreeNode root=new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left=new TreeNode(3);
            
            IList<int> expected=new List<int>(){1,2,3};
            var result = new BinaryTreePreorderTraversal().PreorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalTest1()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);
            root.right=new TreeNode(3);
            root.right.left=new TreeNode(6);
            root.right.right=new TreeNode(7);
            
            IList<int> expected=new List<int>(){1,2,4,5,3,6,7};
            var result = new BinaryTreePreorderTraversal().PreorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalTest2()
        {
            TreeNode root=new TreeNode(1);
            
            IList<int> expected=new List<int>(){1};
            var result = new BinaryTreePreorderTraversal().PreorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalTest3()
        {
            TreeNode root = null;
            
            IList<int> expected=new List<int>(){};
            var result = new BinaryTreePreorderTraversal().PreorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalOfIeterationTest()
        {
            TreeNode root=new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left=new TreeNode(3);
            
            IList<int> expected=new List<int>(){1,2,3};
            var result = new BinaryTreePreorderTraversal().PreorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalOfIeterationTest1()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);
            root.right=new TreeNode(3);
            root.right.left=new TreeNode(6);
            root.right.right=new TreeNode(7);
            
            IList<int> expected=new List<int>(){1,2,4,5,3,6,7};
            var result = new BinaryTreePreorderTraversal().PreorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalOfIeterationTest2()
        {
            TreeNode root=new TreeNode(1);
            
            IList<int> expected=new List<int>(){1};
            var result = new BinaryTreePreorderTraversal().PreorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTraversalOfIeterationTest3()
        {
            TreeNode root = null;
            
            IList<int> expected=new List<int>(){};
            var result = new BinaryTreePreorderTraversal().PreorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }
    }
}