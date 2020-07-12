using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class MergeTwoSortedListsTests
    {
        [Test()]
        public void MergeTwoListsTest()
        {
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(4);
            headA.next = node2;
            node2.next = node3;

            ListNode headB=new ListNode(1);
            ListNode nodeB2=new ListNode(3);
            ListNode nodeB3=new ListNode(4);
            headB.next = nodeB2;
            nodeB2.next = nodeB3;

            ListNode expectedHead=new ListNode(1);
            ListNode expectedNode2=new ListNode(1);
            ListNode expectedNode3=new ListNode(2);
            ListNode expectedNode4=new ListNode(3);
            ListNode expectedNode5=new ListNode(4);
            ListNode expectedNode6=new ListNode(4);
            expectedHead.next = expectedNode2;
            expectedNode2.next = expectedNode3;
            expectedNode3.next = expectedNode4;
            expectedNode4.next = expectedNode5;
            expectedNode5.next = expectedNode6;


            Assert.IsTrue(expectedHead.IsEqual(new MergeTwoSortedLists().MergeTwoLists(headA,headB)));
        }
    }
}