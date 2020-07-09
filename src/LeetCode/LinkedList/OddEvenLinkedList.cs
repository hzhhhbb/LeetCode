using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 328. 奇偶链表
    /// </summary>
   public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode currentNode = head;
            ListNode oddNodeHead = null;
            ListNode evenNodeHead = null;
            ListNode currentOddNode = null;
            ListNode currentEvenNode = null;
            int number = 1;

            while (currentNode!=null)
            {
                if (number % 2 == 1)
                {
                    if (oddNodeHead == null)
                    {
                        oddNodeHead = currentNode;
                        currentOddNode = oddNodeHead;
                    }
                    else
                    {
                        currentOddNode.next = currentNode;
                        currentOddNode = currentOddNode.next;
                    }
                }
                else
                {
                    if (evenNodeHead == null)
                    {
                        evenNodeHead = currentNode;
                        currentEvenNode = evenNodeHead;
                    }
                    else
                    {
                        currentEvenNode.next = currentNode;
                        currentEvenNode = currentEvenNode.next;
                    }
                }

                currentNode = currentNode.next;
                number++;
            }
           
            currentOddNode.next = evenNodeHead;
            currentEvenNode.next = null;
            return oddNodeHead;
        }
    }
}
/*
 * 用两个临时变量存奇节点、偶节点的头节点，然后遍历链表，遇到奇节点就把节点加到奇节点的链表里，偶节点也一样。最后把两个链表连起来，尾节点置为null，返回奇节点链表
 */