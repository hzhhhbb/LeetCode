namespace LeetCode.LinkedList
{
    /// <summary>
    /// 21. 合并两个有序链表
    /// </summary>
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            ListNode newHead = new ListNode(0);

            ListNode currentNode = null;
            if (l1.val <= l2.val)
            {
                currentNode = l1;
                l1 = l1.next;
            }
            else
            {
                currentNode = l2;
                l2 = l2.next;
            }

            newHead.next = currentNode;

            while (l1 != null || l2 != null)
            {
                if (l2 == null)
                {
                    currentNode.next = l1;
                    currentNode = currentNode.next;
                    l1 = l1.next;
                    continue;
                }

                if (l1 == null)
                {
                    currentNode.next = l2;
                    currentNode = currentNode.next;
                    l2 = l2.next;
                    continue;
                }

                if (l1.val <= l2.val)
                {
                    currentNode.next = l1;
                    currentNode = currentNode.next;
                    l1 = l1.next;
                }
                else
                {
                    currentNode.next = l2;
                    currentNode = currentNode.next;
                    l2 = l2.next;
                }
            }

            currentNode.next = null;
            return newHead.next;
        }
    }
}
/*
 * 迭代法：逐一比较两个链表当前节点的值大小，较小值存放在以哨兵节点表示的新链表里，然后移动链表索引，循环以上动作直到迭代到两个链表末尾。返回哨兵节点的下一个节点。时间复杂度O(m+n)，空间复杂度O(1)
 */