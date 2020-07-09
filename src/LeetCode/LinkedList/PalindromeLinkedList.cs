using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 234. 回文链表
    /// </summary>
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }

            List<int> nodeValues = new List<int>();

            while (head != null)
            {
                nodeValues.Add(head.val);
                head = head.next;
            }

            int start = 0;
            int end = nodeValues.Count - 1;
            while (start < end)
            {
                if (nodeValues[start] != nodeValues[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
/*
 * 1、遍历链表，把节点值存到数组里，再用双指针判断是否回文
 * 2、用快慢指针，反转后半段链表，然后判断是否回文
 */