using System.Collections.Generic;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 19. 删除链表的倒数第N个节点
    /// </summary>
    public class RemoveNthNodeFromEndOfList
    {
        // 字典，时间复杂度O(n)，空间复杂度O(n)
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
            {
                return null;
            }

            Dictionary<int, ListNode> kv = new Dictionary<int, ListNode>();
            ListNode tempHead = head;
            int linkedListLength = 0;
            while (tempHead != null)
            {
                kv.Add(linkedListLength, tempHead);
                tempHead = tempHead.next;
                linkedListLength++;
            }

            int nthIndex = linkedListLength - n;

            if (nthIndex == 0)
            {
                return head.next;
            }

            kv[nthIndex - 1].next = kv[nthIndex].next;
            return head;
        }
    }
}