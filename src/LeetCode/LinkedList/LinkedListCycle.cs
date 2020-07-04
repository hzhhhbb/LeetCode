﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 141. 环形链表
    /// </summary>
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> readNodes=new HashSet<ListNode>();

            while (head!=null)
            {
                if (readNodes.Contains(head))
                {
                    return true;
                }

                readNodes.Add(head);
                head = head.next;
            }

            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}