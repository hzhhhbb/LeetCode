using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 61. 旋转链表
    /// </summary>
    public class RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            // close the linked list into the ring
            ListNode oldTail = head;
            int listCount;
            for (listCount = 1; oldTail.next != null; listCount++)
            {
                oldTail = oldTail.next;
            }

            oldTail.next = head;

            // find new tail : (n - k % n - 1)th node
            // and new head : (n - k % n)th node
            ListNode newTail = head;
            for (int i = 0; i < listCount - k % listCount - 1; i++)
            {
                newTail = newTail.next;
            }

            ListNode newHead = newTail.next;

            // break the ring
            newTail.next = null;

            return newHead;

        }
    }
}
/*
 * 把链表弄成环，找到环的新头和新尾，把尾的next置为null，返回新头
 */