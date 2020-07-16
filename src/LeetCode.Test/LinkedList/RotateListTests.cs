using LeetCode.LinkedList;

using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class RotateListTests
    {
        [Test()]
        public void RotateRightTest()
        {
            //旋转次数小于链表长度
            ListNode head = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);

            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            int k = 2;

            ListNode expectedhead = new ListNode(4);
            ListNode expectednode2 = new ListNode(5);
            ListNode expectednode3 = new ListNode(1);
            ListNode expectednode4 = new ListNode(2);
            ListNode expectednode5 = new ListNode(3);

            expectedhead.next = expectednode2;
            expectednode2.next = expectednode3;
            expectednode3.next = expectednode4;
            expectednode4.next = expectednode5;

            Assert.IsTrue(expectedhead.IsEqual(new RotateList().RotateRight(head, k)));
        }

        [Test()]
        public void RotateRightTest1()
        {
            //旋转次数大于链表长度
            ListNode head = new ListNode(0);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(2);

            head.next = node2;
            node2.next = node3;

            int k = 4;

            ListNode expectedhead = new ListNode(2);
            ListNode expectednode2 = new ListNode(0);
            ListNode expectednode3 = new ListNode(1);

            expectedhead.next = expectednode2;
            expectednode2.next = expectednode3;

            Assert.IsTrue(expectedhead.IsEqual(new RotateList().RotateRight(head, k)));
        }

        [Test()]
        public void RotateRightTest2()
        {
            //链表为空
            ListNode head = null;

            int k = 4;

            ListNode expectedhead = null;

            Assert.IsTrue(expectedhead== new RotateList().RotateRight(head, k));
        }

        [Test()]
        public void RotateRightTest3()
        {
            //只有一个节点
            ListNode head = new ListNode(0);

            int k = 4;

            ListNode expectedhead = new ListNode(0);

            Assert.IsTrue(expectedhead.IsEqual(new RotateList().RotateRight(head, k)));
        }
    }
}