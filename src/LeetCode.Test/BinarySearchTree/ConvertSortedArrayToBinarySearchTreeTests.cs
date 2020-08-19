using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class ConvertSortedArrayToBinarySearchTreeTests
    {
        [Test()]
        public void SortedArrayToBSTTest()
        {
            int[] nums = {-10, -3, 0, 5, 9};
            TreeNode root=new TreeNode(0);
            root.left=new TreeNode(-10);
            root.left.right=new TreeNode(-3);
            root.right=new TreeNode(5);
            root.right.right=new TreeNode(9);
            
            TreeNode result=new ConvertSortedArrayToBinarySearchTree().SortedArrayToBST(nums);
            Assert.IsTrue(root.val==result.val);
            Assert.IsTrue(root.left.right.val==result.left.right.val);
            Assert.IsTrue(root.right.val==result.right.val);
            Assert.IsTrue(root.right.right.val==result.right.right.val);
        }
    }
}