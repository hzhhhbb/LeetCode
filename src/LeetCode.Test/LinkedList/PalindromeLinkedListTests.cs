using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.Tests.LinkedList
{
    [TestFixture()]
    public class PalindromeLinkedListTests
    {
        [Test()]
        public void IsPalindromeTest()
        {
            //回文链表
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(2);
            ListNode node4=new ListNode(1);

            headA.next = node2;
            node2.next = node3;
            node3.next = node4;
          

            bool expected = true;
            Assert.AreEqual(expected,new PalindromeLinkedList().IsPalindrome(headA));
        }

        [Test()]
        public void IsPalindromeTest1()
        {
            // 非回文链表
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(2);
            ListNode node4=new ListNode(3);

            headA.next = node2;
            node2.next = node3;
            node3.next = node4;

            bool expected = false;
            Assert.AreEqual(expected,new PalindromeLinkedList().IsPalindrome(headA));
        }

        [Test()]
        public void IsPalindromeTest2()
        {
            // 非回文链表
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(2);

            headA.next = node2;

            bool expected = false;
            Assert.AreEqual(expected,new PalindromeLinkedList().IsPalindrome(headA));
        }

        [Test()]
        public void IsPalindromeTest3()
        {
            // 回文链表
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(1);

            headA.next = node2;
            

            bool expected = true;
            Assert.AreEqual(expected,new PalindromeLinkedList().IsPalindrome(headA));
        }

        [Test()]
        public void IsPalindromeTest4()
        {
            // 非回文链表
            ListNode headA=new ListNode(1);
            ListNode node2=new ListNode(2);
            ListNode node3=new ListNode(1);

            headA.next = node2;
            node2.next = node3;
        

            bool expected = true;
            Assert.AreEqual(expected,new PalindromeLinkedList().IsPalindrome(headA));
        }
    }
}