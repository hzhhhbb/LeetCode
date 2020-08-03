using LeetCode.LinkedList;

using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class AddTwoNumbersTests
    {
        [Test()]
        public void AddTwoNumbersTest()
        {
            ListNode headA = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            headA.next = node2;
            node2.next = node3;

            ListNode headB = new ListNode(0);
            ListNode nodeB2 = new ListNode(1);
            headB.next = nodeB2;

            ListNode expected = new ListNode(1);
            ListNode expected1 = new ListNode(3);
            ListNode expected2 = new ListNode(3);
            expected.next = expected1;
            expected1.next = expected2;

            Assert.IsTrue(expected.IsEqual(new AddTwoNumbersClass().AddTwoNumbers(headA, headB)));
        }

        [Test()]
        public void AddTwoNumbersTest1()
        {
            ListNode headA = new ListNode(0);
            ListNode node2 = new ListNode(9);
            ListNode node3 = new ListNode(9);
            headA.next = node2;
            node2.next = node3;

            ListNode headB = new ListNode(0);
            ListNode nodeB2 = new ListNode(1);
            headB.next = nodeB2;

            ListNode expected = new ListNode(0);
            ListNode expected1 = new ListNode(0);
            ListNode expected2 = new ListNode(0);
            ListNode expected3 = new ListNode(1);
            expected.next = expected1;
            expected1.next = expected2;
            expected2.next = expected3;

            Assert.IsTrue(expected.IsEqual(new AddTwoNumbersClass().AddTwoNumbers(headA, headB)));
        }
    }
}