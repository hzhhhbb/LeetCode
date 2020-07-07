using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 206. 反转链表
    /// </summary>
   public class ReverseLinkedList
    {
        //迭代
        public ListNode ReverseList(ListNode head) 
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var currentNode = head;
            ListNode prevNode = null;

            while (currentNode!=null)
            {
                ListNode nextNode = currentNode.next;
                currentNode.next = prevNode;

                prevNode = currentNode;
                currentNode = nextNode;
            }

            return prevNode;
        }

        //递归 //todo
        public ListNode ReverseList1(ListNode head) 
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode p = this.ReverseList1(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }
    }
}
