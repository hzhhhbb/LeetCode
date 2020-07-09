using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class OddEvenLinkedListTests
    {
        [Test()]
        public void OddEvenListTest()
        {
            // 奇偶链表
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(3);
            ListNode node4=new ListNode(4);
            ListNode node5=new ListNode(5);
            headA.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            ListNode headB=new ListNode(1);
            ListNode nodeB2=new ListNode(2);
            ListNode nodeB3=new ListNode(3);
            ListNode nodeB4=new ListNode(4);
            ListNode nodeB5=new ListNode(5);
            headB.next = nodeB3;
            nodeB3.next = nodeB5;
            nodeB5.next = nodeB2;
            nodeB2.next = nodeB4;

            headA = new OddEvenLinkedList().OddEvenList(headA);
            Assert.IsTrue(headA.IsEqual(headB));
        }
    }
}