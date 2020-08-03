using System.Collections.Generic;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 160. 相交链表
    /// </summary>
    public class IntersectionOfTwoLinkedLists
    {
        // 哈希表法
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            HashSet<ListNode> a = new HashSet<ListNode>();
            ListNode headANode = headA;
            while (headANode != null)
            {
                a.Add(headANode);
                headANode = headANode.next;
            }

            ListNode headBNode = headB;
            while (headBNode != null)
            {
                if (a.Contains(headBNode))
                {
                    return headBNode;
                }

                headBNode = headBNode.next;
            }

            return null;
        }

        // 双指针法
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            ListNode tempHeadA = headA;
            ListNode tempHeadB = headB;
            bool aVisitedB = false;
            bool bVisitedA = false;
            while (tempHeadA != tempHeadB)
            {
                if (tempHeadA == null)
                {
                    if (!aVisitedB)
                    {
                        tempHeadA = headB;
                        aVisitedB = true;
                    }
                }
                else
                {
                    tempHeadA = tempHeadA.next;
                }

                if (tempHeadB == null)
                {
                    if (!bVisitedA)
                    {
                        tempHeadB = headA;
                        bVisitedA = true;
                    }
                }
                else
                {
                    tempHeadB = tempHeadB.next;
                }

                if (tempHeadA == null && tempHeadB == null && aVisitedB && bVisitedA)
                {
                    break;
                }
            }

            return tempHeadA == tempHeadB ? tempHeadA : null;
        }
    }
}