using LeetCode.LinkedList;

using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class IntersectionOfTwoLinkedListsTests
    {
        [Test()]
        public void GetIntersectionNodeTest()
        {
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

            ListNode headB = new ListNode(0);
            ListNode nodeB2 = new ListNode(7);
            ListNode nodeB3 = new ListNode(8);
            ListNode nodeB4 = new ListNode(9);
            headB.next = nodeB2;
            nodeB2.next = nodeB3;
            nodeB3.next = nodeB4;

            // 相交节点为node4
            nodeB4.next = node4;

            var expected = node4;
            Assert.AreSame(expected, new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB));
            Assert.AreSame(expected, new IntersectionOfTwoLinkedLists().GetIntersectionNode1(headA, headB));
        }

        [Test()]
        public void GetIntersectionNodeTest1()
        {
            ListNode headA = new ListNode(1);
            ListNode headB = headA;

            var expected = headA;
            Assert.AreSame(expected, new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB));
            Assert.AreSame(expected, new IntersectionOfTwoLinkedLists().GetIntersectionNode1(headA, headB));
        }

        [Test()]
        public void GetIntersectionNodeTest2()
        {
            ListNode headA = new ListNode(1);
            ListNode headB = new ListNode(2);

            ListNode expected = null;
            Assert.AreSame(expected, new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB));
            Assert.AreSame(expected, new IntersectionOfTwoLinkedLists().GetIntersectionNode1(headA, headB));
        }
    }
}