namespace LeetCode.LinkedList
{
    /// <summary>
    /// 707. 设计链表（单链表）
    /// </summary>
    public class MyLinkedList
    {
        class ListNode
        {
            public int Value;
            public ListNode Next = null;

            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        public int Size;
        private ListNode sentinelHead;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            this.Size = 0;
            sentinelHead = new ListNode(0);
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index >= Size || index < 0)
            {
                return -1;
            }

            var node = this.sentinelHead;
            for (int i = 0; i < index + 1; i++)
            {
                node = node.Next;
            }

            return node?.Value ?? -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode node = new ListNode(val);

            node.Next = this.sentinelHead.Next;
            this.sentinelHead.Next = node;
            this.Size++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (this.Size == 0)
            {
                this.AddAtHead(val);
                return;
            }

            ListNode newNode = new ListNode(val);
            var node = this.sentinelHead;

            for (int i = 0; i < Size; i++)
            {
                node = node.Next;
            }

            node.Next = newNode;
            this.Size++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0)
            {
                this.AddAtHead(val);
                return;
            }

            if (index == this.Size)
            {
                this.AddAtTail(val);
                return;
            }

            if (index > this.Size)
            {
                return;
            }

            ListNode newNode = new ListNode(val);
            var node = this.sentinelHead;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            newNode.Next = node.Next;
            node.Next = newNode;
            this.Size++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= this.Size)
            {
                return;
            }
            
            var node = sentinelHead;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            node.Next = node.Next.Next;
            this.Size--;
        }
    }

    /// <summary>
    /// 707. 设计链表（双链表）
    /// </summary>
    public class MyLinkedList2
    {
        class ListNode
        {
            public int Value;

            public ListNode Next = null;

            public ListNode Prev = null;

            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        public int Size;
        private ListNode sentinelHead;

        /** Initialize your data structure here. */
        public MyLinkedList2()
        {
            this.Size = 0;
            sentinelHead = new ListNode(0);
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index >= Size || index < 0)
            {
                return -1;
            }

            var node = this.sentinelHead;
            for (int i = 0; i < index + 1; i++)
            {
                node = node.Next;
            }

            return node?.Value ?? -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode node = new ListNode(val);

            if (this.Size==0)
            {
                this.sentinelHead.Next = node;
                node.Prev = this.sentinelHead;
            }
            else
            {
                this.sentinelHead.Next.Prev = node;
                node.Next = this.sentinelHead.Next;
                this.sentinelHead.Next = node;
            }

            this.Size++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (this.Size == 0)
            {
                this.AddAtHead(val);
                return;
            }

            ListNode newNode = new ListNode(val);
            var node = this.sentinelHead;

            for (int i = 0; i < Size; i++)
            {
                node = node.Next;
            }

            node.Next = newNode;
            newNode.Prev = node;
            this.Size++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0)
            {
                this.AddAtHead(val);
                return;
            }

            if (index == this.Size)
            {
                this.AddAtTail(val);
                return;
            }

            if (index > this.Size)
            {
                return;
            }

            ListNode newNode = new ListNode(val);

            var currentNode = this.sentinelHead;
            for (int i = 0; i < index+1; i++)
            {
                currentNode = currentNode.Next;
            }

            newNode.Prev = currentNode.Prev;
            newNode.Next = currentNode;
            currentNode.Prev.Next = newNode;
            currentNode.Prev = newNode;

            this.Size++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= this.Size)
            {
                return;
            }

            var currentNode = sentinelHead;
            for (int i = 0; i < index+1; i++)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Prev.Next = currentNode.Next;
            if (currentNode.Next != null)
            {
                currentNode.Next.Prev = currentNode.Prev;
            }

            this.Size--;
        }
    }


    /*
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
    /*
     * 理解链表特性、认真审题即可
     */
}