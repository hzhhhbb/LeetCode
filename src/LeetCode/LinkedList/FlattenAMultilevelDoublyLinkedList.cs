using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 430. 扁平化多级双向链表
    /// </summary>
    public class FlattenAMultilevelDoublyLinkedList
    {
        public Node Flatten(Node head)
        {
            if (head == null)
            {
                return head;
            }

            Node tempHead0=new Node(-1);
            Node tempHead = new Node(-1);
            tempHead0.next = tempHead;
            tempHead.next = head;

            this.Flatten(tempHead, tempHead.next);
            tempHead0.next.next.prev = null;
            return tempHead0.next.next;
        }

        public Node Flatten(Node currentNode, Node child)
        {
            while (child != null)
            {
                child.prev = currentNode;
                currentNode.next = child;
                currentNode = currentNode.next;

                if (child.child != null)
                {
                    Node tempNext = child.next;
                    Node tempChild = child.child;
                    child.child = null;

                    currentNode= this.Flatten(currentNode, tempChild);
                    child = tempNext;
                }
                else
                {
                    child = child.next;
                }
            }

            return currentNode;
        }
    }

    public class Node
    {
        public int val;

        public Node prev;

        public Node next;

        public Node child;

        public Node(int value)
        {
            this.val = value;
            this.prev = null;
            this.next = null;
            this.child = null;
        }

        public Node()
        {
            this.prev = null;
            this.next = null;
            this.child = null;
        }
    }

    public static class NodeExtension
    {
        public static bool IsEqual(this Node source, Node other)
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