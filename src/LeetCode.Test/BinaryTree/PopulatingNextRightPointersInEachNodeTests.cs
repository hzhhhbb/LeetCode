using NUnit.Framework;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class PopulatingNextRightPointersInEachNodeTests
    {
        [Test()]
        public void ConnectTest()
        {
            Node root=new Node(1);
            root.left=new Node(2);
            root.left.left=new Node(4);
            root.left.right=new Node(5);
            root.right=new Node(3);
            root.right.left=new Node(6);
            root.right.right=new Node(7);
            new PopulatingNextRightPointersInEachNode().Connect(root);

            Assert.IsTrue(root.left.next.val==3);
            Assert.IsTrue(root.left.left.next.val==5);
            Assert.IsTrue(root.left.right.next.val==6);
            Assert.IsTrue(root.right.left.next.val==7);
        }
    }
}