using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class LowestCommonAncestorOfABinarySearchTreeTests
    {
        [Test()]
        public void LowestCommonAncestorTest()
        {
            TreeNode root=new TreeNode(6);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(0);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.left.right.right=new TreeNode(5);
            root.right=new TreeNode(8);
            root.right.left=new TreeNode(7);
            root.right.right=new TreeNode(9);

            TreeNode p = root.left;
            TreeNode q = root.right;
            TreeNode expected = root;
            TreeNode result = new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root, p, q);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LowestCommonAncestorTest1()
        {
            TreeNode root=new TreeNode(6);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(0);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.left.right.right=new TreeNode(5);
            root.right=new TreeNode(8);
            root.right.left=new TreeNode(7);
            root.right.right=new TreeNode(9);

            TreeNode p = root.left.left;
            TreeNode q = root.left.right.right;
            TreeNode expected =  root.left;
            TreeNode result = new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root, p, q);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LowestCommonAncestorTest2()
        {
            TreeNode root=new TreeNode(6);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(0);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.left.right.right=new TreeNode(5);
            root.right=new TreeNode(8);
            root.right.left=new TreeNode(7);
            root.right.right=new TreeNode(9);

            TreeNode p =  root.left;
            TreeNode q = root.left.right.right;
            TreeNode expected =  root.left;
            TreeNode result = new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root, p, q);
            Assert.AreEqual(expected,result);
        }

        
        [Test()]
        public void LowestCommonAncestorTest3()
        {
            TreeNode root=new TreeNode(6);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(0);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.left.right.right=new TreeNode(5);
            root.right=new TreeNode(8);
            root.right.left=new TreeNode(7);
            root.right.right=new TreeNode(9);

            TreeNode p =  root;
            TreeNode q =  root.right.right;
            TreeNode expected =  root;
            TreeNode result = new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root, p, q);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LowestCommonAncestorTest4()
        {
            TreeNode root=new TreeNode(6);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(0);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.left.right.right=new TreeNode(5);
            root.right=new TreeNode(8);
            root.right.left=new TreeNode(7);
            root.right.right=new TreeNode(9);

            TreeNode p =   root.right.right;
            TreeNode q =  root.right.left;
            TreeNode expected =    root.right;
            TreeNode result = new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root, p, q);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LowestCommonAncestorTest5()
        {
            TreeNode root=new TreeNode(6);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(0);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.left.right.right=new TreeNode(5);
            root.right=new TreeNode(8);
            root.right.left=new TreeNode(7);
            root.right.right=new TreeNode(9);

            TreeNode p =   root.right.right;
            TreeNode q =  root.left.right.right;
            TreeNode expected =    root;
            TreeNode result = new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root, p, q);
            Assert.AreEqual(expected,result);
        }
    }
}