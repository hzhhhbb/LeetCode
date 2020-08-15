using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class InsertIntoABinarySearchTreeTests
    {
        [Test()]
        public void InsertIntoBSTTest()
        {
            TreeNode root=new TreeNode(4);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(3);
            root.right=new TreeNode(7);
            root=new InsertIntoABinarySearchTree().InsertIntoBST(root, 5);

            Assert.IsTrue(root.right.left.val==5);
        }

        [Test()]
        public void InsertIntoBSTTest1()
        {
            TreeNode root = null;
            root=new InsertIntoABinarySearchTree().InsertIntoBST(root, 5);

            Assert.IsTrue(root.val==5);
        }
    }
}