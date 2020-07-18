namespace LeetCode.LinkedList
{
    /// <summary>
    /// 2. 两数相加
    /// </summary>
    public class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            ListNode tempHead = new ListNode();
            ListNode currentNode = null;
            int forward = 0;
            int currentSum = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    currentSum = l2.val + forward;
                    l2 = l2.next;
                }

                if (l2 == null && l1 != null)
                {
                    currentSum = l1.val + forward;
                    l1 = l1.next;
                }

                if (l1 != null && l2 != null)
                {
                    currentSum = l1.val + l2.val + forward;
                    l1 = l1.next;
                    l2 = l2.next;
                }

                forward = currentSum >= 10 ? 1 : 0;
                ListNode tempNode = new ListNode(currentSum >= 10 ? currentSum - 10 : currentSum);
                if (currentNode == null)
                {
                    currentNode = tempNode;
                    tempHead.next = currentNode;
                }
                else
                {
                    currentNode.next = tempNode;
                    currentNode = currentNode.next;
                }
            }

            if (forward == 1)
            {
                currentNode.next = new ListNode(forward);
            }

            return tempHead.next;
        }
    }
}