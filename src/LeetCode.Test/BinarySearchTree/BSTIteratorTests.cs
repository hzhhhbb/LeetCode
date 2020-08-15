using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class BSTIteratorTests
    {
        [Test()]
        public void BSTIteratorTest()
        {
            TreeNode root=new TreeNode(2);
            root.left=new TreeNode(1);
            root.right=new TreeNode(3);
            
            BSTIterator bst=new BSTIterator(root);
        }

        [Test()]
        public void NextTest()
        {
            TreeNode root=new TreeNode(2);
            root.left=new TreeNode(1);
            root.right=new TreeNode(3);
            
            BSTIterator bst=new BSTIterator(root);
            Assert.IsTrue(bst.Next()==1);
            Assert.IsTrue(bst.Next()==2);
            Assert.IsTrue(bst.Next()==3);
        }

        [Test()]
        public void HasNextTest()
        {
            TreeNode root=new TreeNode(2);
            root.left=new TreeNode(1);
            root.right=new TreeNode(3);
            
            BSTIterator bst=new BSTIterator(root);
            Assert.IsTrue(bst.HasNext());
            Assert.IsTrue(bst.Next()==1);
            Assert.IsTrue(bst.HasNext());
            Assert.IsTrue(bst.Next()==2);
            Assert.IsTrue(bst.HasNext());
            Assert.IsTrue(bst.Next()==3);
            Assert.IsFalse(bst.HasNext());
        }
    }
}