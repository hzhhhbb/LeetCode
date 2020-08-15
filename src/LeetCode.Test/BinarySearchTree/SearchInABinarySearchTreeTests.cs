using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class SearchInABinarySearchTreeTests
    {
        [Test()]
        public void SearchBSTTest()
        {
            TreeNode root=new TreeNode(4);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(3);
            root.right=new TreeNode(7);

            int targetValue = 2;
            TreeNode expected = root.left;
            TreeNode result = new SearchInABinarySearchTree().SearchBST(root, targetValue);
            Assert.AreSame(expected,result);
        }

        
        [Test()]
        public void SearchBSTTest1()
        {
            TreeNode root = null;

            int targetValue = 2;
            TreeNode expected = null;
            TreeNode result = new SearchInABinarySearchTree().SearchBST(root, targetValue);
            Assert.AreSame(expected,result);
        }

        [Test()]
        public void SearchBSTTest2()
        {
            TreeNode root=new TreeNode(4);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(3);
            root.right=new TreeNode(7);

            int targetValue = 8;
            TreeNode expected = null;
            TreeNode result = new SearchInABinarySearchTree().SearchBST(root, targetValue);
            Assert.AreSame(expected,result);
        }
    }
}