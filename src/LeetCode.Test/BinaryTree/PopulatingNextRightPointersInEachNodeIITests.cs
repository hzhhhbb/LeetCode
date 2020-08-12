using NUnit.Framework;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class PopulatingNextRightPointersInEachNodeIITests
    {
        [Test()]
        public void ConnectTest()
        {
            Node root=new Node(1);
            root.left=new Node(2);
            root.left.left=new Node(4);
            root.left.right=new Node(5);
            root.right=new Node(3);
           
            root.right.right=new Node(7);
            new PopulatingNextRightPointersInEachNodeII().Connect(root);

            Assert.IsTrue(root.left.next.val==3);
            Assert.IsTrue(root.left.left.next.val==5);
            Assert.IsTrue(root.left.right.next.val==7);
        }

        [Test()]
        public void ConnectTest1()
        {
            Node root=new Node(1);
            root.left=new Node(2);
            root.left.left=new Node(4);
            root.right=new Node(3);
            root.right.right=new Node(5);
            new PopulatingNextRightPointersInEachNodeII().Connect(root);

            Assert.IsTrue(root.left.next.val==3);
            Assert.IsTrue(root.left.left.next.val==5);
        }

        [Test()]
        public void ConnectTest2()
        {
            Node root=new Node(1);
            root.left=new Node(2);
            root.left.left=new Node(3);
            root.left.left.left=new Node(5);
            new PopulatingNextRightPointersInEachNodeII().Connect(root);

           Assert.IsTrue(root.left.next==null);
        }
        [Test()]
        public void ConnectTest3()
        {
            Node root=new Node(1);
            root.left=new Node(2);
            root.left.left=new Node(4);
            root.left.right=new Node(5);
            root.left.left.left=new Node(7);
            root.right=new Node(3);
            root.right.right=new Node(6);
            root.right.right.right=new Node(8);
            new PopulatingNextRightPointersInEachNodeII().Connect(root);

            Assert.IsTrue( root.left.left.left.next.val==8);
        }
    }
}