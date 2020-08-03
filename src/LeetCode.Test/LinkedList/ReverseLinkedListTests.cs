using LeetCode.LinkedList;

using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class ReverseLinkedListTests
    {
        [Test()]
        public void ReverseListTest()
        {
            ListNode head = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            ListNode expected = new ListNode(5);
            ListNode node44 = new ListNode(4);
            ListNode node33 = new ListNode(3);
            ListNode node22 = new ListNode(2);
            ListNode node11 = new ListNode(1);
            expected.next = node44;
            node44.next = node33;
            node33.next = node22;
            node22.next = node11;

            ListNode result = new ReverseLinkedList().ReverseList(head);
            Assert.IsTrue(expected.IsEqual(result));
        }

        [Test()]
        public void ReverseListTest1()
        {
            ListNode head = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            ListNode expected = new ListNode(5);
            ListNode node44 = new ListNode(4);
            ListNode node33 = new ListNode(3);
            ListNode node22 = new ListNode(2);
            ListNode node11 = new ListNode(1);
            expected.next = node44;
            node44.next = node33;
            node33.next = node22;
            node22.next = node11;

            ListNode result = new ReverseLinkedList().ReverseList1(head);
            Assert.IsTrue(expected.IsEqual(result));
        }
    }
}