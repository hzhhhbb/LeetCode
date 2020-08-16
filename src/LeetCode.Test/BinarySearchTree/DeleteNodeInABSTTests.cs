using NUnit.Framework;
using LeetCode.BinarySearchTree;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class DeleteNodeInABSTTests
    {
        [Test()]
        public void DeleteNodeTest()
        {
            //目标节点没有子节点
            TreeNode root=new TreeNode(5);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.right=new TreeNode(6);
            root.right.right=new TreeNode(7);

            int targetNodeValue = 7;
            root=new DeleteNodeInABST().DeleteNode(root,targetNodeValue);
            Assert.IsTrue(root.right.right == null);
        }

        [Test()]
        public void DeleteNodeTest1()
        {
            //目标节点只有一个子节点
            TreeNode root=new TreeNode(5);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.right=new TreeNode(6);
            root.right.right=new TreeNode(7);

            int targetNodeValue = 6;
            root=new DeleteNodeInABST().DeleteNode(root,targetNodeValue);
            Assert.IsTrue(root.right.val == 7);
        }

        [Test()]
        public void DeleteNodeTest2()
        {
            //目标节点有两个子节点
            TreeNode root=new TreeNode(5);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.right=new TreeNode(6);
            root.right.right=new TreeNode(7);

            int targetNodeValue = 2;
            root=new DeleteNodeInABST().DeleteNode(root,targetNodeValue);
            Assert.IsTrue(root.left.val==3);
        }

        [Test()]
        public void DeleteNodeTest3()
        {
            //目标节点是根节点
            TreeNode root=new TreeNode(5);
            root.left=new TreeNode(2);
            root.left.left=new TreeNode(1);
            root.left.right=new TreeNode(4);
            root.left.right.left=new TreeNode(3);
            root.right=new TreeNode(6);
            root.right.right=new TreeNode(7);

            int targetNodeValue = 5;
            root=new DeleteNodeInABST().DeleteNode(root,targetNodeValue);
            Assert.IsTrue(root.val==6&&root.right.val==7&&root.left.val==2);
        }
    }
}