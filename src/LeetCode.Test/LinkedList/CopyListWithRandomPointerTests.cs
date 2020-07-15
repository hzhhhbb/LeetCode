namespace LeetCode.Tests.LinkedList
{
    using LeetCode.LinkedList;

    using NUnit.Framework;

    [TestFixture()]
    public class CopyListWithRandomPointerTests
    {
        [Test()]
        public void CopyRandomListTest()
        {
            // 此测试只测试了值相等的情况，未测试random的情况
            Node head=new Node(0);
            Node node1=new Node(1);
            Node node2=new Node(2);
            Node node3=new Node(3);
            Node node4=new Node(4);
            Node node5=new Node(5);
            Node node6 = new Node(6);

            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;

            node1.random = node1;
            node2.random = null;
            node3.random = node5;
            node6.random = node2;



            Node expected = new Node(0);
            Node expectednode1 = new Node(1);
            Node expectednode2 = new Node(2);
            Node expectednode3 = new Node(3);
            Node expectednode4 = new Node(4);
            Node expectednode5 = new Node(5);
            Node expectednode6 = new Node(6);

            expected.next = expectednode1;
            expectednode1.next = expectednode2;
            expectednode2.next = expectednode3;
            expectednode3.next = expectednode4;
            expectednode4.next = expectednode5;
            expectednode5.next = expectednode6;

            expectednode1.random = expectednode1;
            expectednode2.random = null;
            expectednode3.random = expectednode5;
            expectednode6.random = expectednode2;

            var result = new CopyListWithRandomPointer().CopyRandomList(head);

            Assert.IsTrue(expected.IsEqual(result));
        }
    }
}