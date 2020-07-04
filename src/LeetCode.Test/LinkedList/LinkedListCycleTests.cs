using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class LinkedListCycleTests
    {
        [Test()]
        public void HasCycleTest()
        {
            //有环
            ListNode head=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(3);
            ListNode node4=new ListNode(4);
            ListNode node5=new ListNode(5);
            ListNode node6=new ListNode(6);
            head.next = node2.next = node3.next = node4.next = node5.next = node6.next=head;

            Assert.AreEqual(true,new LinkedListCycle().HasCycle(head));
        }

        [Test()]
        public void HasCycleTest1()
        {
            //无环
            ListNode head=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(3);
            ListNode node4=new ListNode(4);
            ListNode node5=new ListNode(5);
            ListNode node6=new ListNode(6);
            head.next = node2.next = node3.next = node4.next = node5.next = node6;

            Assert.AreEqual(false,new LinkedListCycle().HasCycle(head));
        }
    }
}