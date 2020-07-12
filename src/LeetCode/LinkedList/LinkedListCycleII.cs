using System.Collections.Generic;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 142. 环形链表 II
    /// </summary>
    public class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head?.next == null)
            {
                return null;
            }
            
            HashSet<ListNode> visited=new HashSet<ListNode>();
            ListNode node = head;
            while (node!=null)
            {
                if (visited.Contains(node))
                {
                    return node;
                }

                visited.Add(node);
                node = node.next;
            }

            return null;
        }

        public ListNode DetectCycle1(ListNode head)
        {
            if (head?.next == null)
            {
                return null;
            }

            ListNode slowNode = head;
            ListNode fastNode = head;
            while (fastNode?.next!=null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
                if (slowNode == fastNode)
                {
                    break;
                }
            }

            if (fastNode?.next == null)
            {
                return null;
            }
            
            ListNode headNode = head;
            while (headNode!=slowNode)
            {
                headNode = headNode.next;
                slowNode = slowNode.next;
            }

            return slowNode;
        }
    }
}
/*
 * 1.遍历链表，记录访问过的节点，如果再次访问到此节点，表示链表有环，返回该节点即可
 * 2.利用快慢指针，慢指针每走一步，快指针走两步，找到相遇点；然后从链表头和相遇点同时开始走链表，再次相遇点即为入口点
 */