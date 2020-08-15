using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class BSTIteratorIITests
    {
        [Test()]
        public void BSTIteratorIITest()
        {
            TreeNode root=new TreeNode(2);
            root.left=new TreeNode(1);
            root.right=new TreeNode(3);
            
            BSTIteratorII bst=new BSTIteratorII(root);
        }

        [Test()]
        public void NextTest()
        {
            TreeNode root=new TreeNode(2);
            root.left=new TreeNode(1);
            root.right=new TreeNode(3);
            
            BSTIteratorII bst=new BSTIteratorII(root);
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
            
            BSTIteratorII bst=new BSTIteratorII(root);
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