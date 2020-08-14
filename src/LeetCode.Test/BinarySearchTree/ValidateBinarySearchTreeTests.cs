using NUnit.Framework;

namespace LeetCode.Tests.BinarySearchTree
{
    using LeetCode.BinarySearchTree;
    using LeetCode.BinaryTree;

    [TestFixture()]
    public class ValidateBinarySearchTreeTests
    {
        [Test()]
        public void IsValidBSTTest()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.right=new TreeNode(3);
            bool expected = false;

            bool result=new ValidateBinarySearchTree().IsValidBST(root);

            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void IsValidBSTTest1()
        {
            TreeNode root=new TreeNode(2);
            root.left=new TreeNode(1);
            root.right=new TreeNode(3);
            bool expected = true;

            bool result=new ValidateBinarySearchTree().IsValidBST(root);

            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void IsValidBSTTest2()
        {
            TreeNode root=new TreeNode(5);
            root.left=new TreeNode(1);
            root.right=new TreeNode(4);
            root.right.left=new TreeNode(3);
            root.right.right=new TreeNode(6);
            bool expected = false;

            bool result=new ValidateBinarySearchTree().IsValidBST(root);

            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void IsValidBSTTest3()
        {
            TreeNode root = null;
            bool expected = true;

            bool result=new ValidateBinarySearchTree().IsValidBST(root);

            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void IsValidBSTTest4()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(1);
            bool expected = false;

            bool result=new ValidateBinarySearchTree().IsValidBST(root);

            Assert.AreEqual(expected,result);
        }

        
        [Test()]
        public void IsValidBSTTest5()
        {
            //[10,5,15,null,null,6,20]
            TreeNode root=new TreeNode(10);
            root.left=new TreeNode(5);
            root.right=new TreeNode(15);
            root.right.left=new TreeNode(6);
            root.right.right=new TreeNode(20);
            bool expected = false;

            bool result=new ValidateBinarySearchTree().IsValidBST(root);

            Assert.AreEqual(expected,result);
        }
    }
}