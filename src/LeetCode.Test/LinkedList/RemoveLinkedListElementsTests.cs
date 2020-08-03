using LeetCode.LinkedList;

using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class RemoveLinkedListElementsTests
    {
        [Test()]
        public void RemoveElementsTest()
        {
            // 删除中间结点
            ListNode headA = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);
            ListNode node6 = new ListNode(6);
            headA.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;

            ListNode headB = new ListNode(1);
            ListNode nodeB2 = new ListNode(2);
            ListNode nodeB3 = new ListNode(3);
            ListNode nodeB4 = new ListNode(4);
            ListNode nodeB6 = new ListNode(6);
            headB.next = nodeB2;
            nodeB2.next = nodeB3;
            nodeB3.next = nodeB4;
            nodeB4.next = nodeB6;

            headA = new RemoveLinkedListElements().RemoveElements(headA, 5);
            Assert.IsTrue(headA.IsEqual(headB));
        }
    }
}