using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class LinkedListCycleIITests
    {
        [Test()]
        public void DetectCycleTest()
        {
            //有环，尾部连接到node2
            ListNode head=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(3);
            ListNode node4=new ListNode(4);
            ListNode node5=new ListNode(5);
            ListNode node6=new ListNode(6);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node2;

            var expected = node2;

            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle(head));
            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle1(head));
        }

        [Test()]
        public void DetectCycleTest1()
        {
            //有环，尾部连接到head
            ListNode head=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(3);
            ListNode node4=new ListNode(4);
            ListNode node5=new ListNode(5);
            ListNode node6=new ListNode(6);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = head;

            var expected = head;

            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle(head));
            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle1(head));
        }

        [Test()]
        public void DetectCycleTest2()
        {
            //无环
            ListNode head=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(3);
            ListNode node4=new ListNode(4);
            ListNode node5=new ListNode(5);
            ListNode node6=new ListNode(6);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;

            ListNode expected = null;

            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle(head));
            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle1(head));
        }

        [Test()]
        public void DetectCycleTest3()
        {
            //无环
            ListNode head=new ListNode(1);

            ListNode expected = null;

            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle(head));
            Assert.AreSame(expected,new LinkedListCycleII().DetectCycle1(head));
        }
    }
}