namespace LeetCode.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class ListNodeExtension
    {
        public static bool IsEqual(this ListNode source, ListNode other)
        {
            var isEqual = true;
            while (true)
            {
                if (source == null || other == null)
                {
                    isEqual = source == other;
                    break;
                }

                if (source.val == other.val)
                {
                    source = source.next;
                    other = other.next;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }

            return isEqual;
        }
    }
}