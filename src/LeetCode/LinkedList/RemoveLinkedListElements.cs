namespace LeetCode.LinkedList
{
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }

            ListNode tempHead = new ListNode(0);
            tempHead.next = head;

            ListNode currentNode = tempHead;
            while (currentNode.next != null && currentNode != null)
            {
                if (currentNode.next.val == val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }

            return tempHead.next;
        }
    }
}
/*
 * 用一个哨兵节点当伪头，避免链表为空的情况出现
 */