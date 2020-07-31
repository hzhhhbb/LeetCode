using NUnit.Framework;
using LeetCode.BinaryTree;
using System.Collections.Generic;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    [Timeout(10000)]
    public class BinaryTreeInorderTraversalTests
    {
         [Test()]
        public void InorderTraversalTest()
        {
            TreeNode root=new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left=new TreeNode(3);
            
            IList<int> expected=new List<int>(){1,3,2};
            var result = new BinaryTreeInorderTraversal().InorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalTest1()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);
            root.right=new TreeNode(3);
            root.right.left=new TreeNode(6);
            root.right.right=new TreeNode(7);
            
            IList<int> expected=new List<int>(){4,2,5,1,6,3,7};
            var result = new BinaryTreeInorderTraversal().InorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalTest2()
        {
            TreeNode root=new TreeNode(1);
            
            IList<int> expected=new List<int>(){1};
            var result = new BinaryTreeInorderTraversal().InorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalTest3()
        {
            TreeNode root = null;
            
            IList<int> expected=new List<int>(){};
            var result = new BinaryTreeInorderTraversal().InorderTraversal(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalOfIeterationTest()
        {
            TreeNode root=new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left=new TreeNode(3);
            
            IList<int> expected=new List<int>(){1,3,2};
            var result = new BinaryTreeInorderTraversal().InorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalOfIeterationTest1()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(4);
            root.left.right=new TreeNode(5);
            root.right=new TreeNode(3);
            root.right.left=new TreeNode(6);
            root.right.right=new TreeNode(7);
            
            IList<int> expected=new List<int>(){4,2,5,1,6,3,7};
            var result = new BinaryTreeInorderTraversal().InorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalOfIeterationTest2()
        {
            TreeNode root=new TreeNode(1);
            
            IList<int> expected=new List<int>(){1};
            var result = new BinaryTreeInorderTraversal().InorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void InorderTraversalOfIeterationTest3()
        {
            TreeNode root = null;
            
            IList<int> expected=new List<int>(){};
            var result = new BinaryTreeInorderTraversal().InorderTraversalOfIteration(root);
            Assert.AreEqual(expected,result);
        }
    }
}