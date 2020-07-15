using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 138. 复制带随机指针的链表
    /// </summary>
    public class CopyListWithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return head;
            }
            Node tempHead=new Node(-1);
            Node currentNode=new Node(-2);
            tempHead.next = currentNode;

            Dictionary<Node,Node> kv=new Dictionary<Node, Node>();

            while (head!=null)
            {
                if (kv.ContainsKey(head))
                {
                    currentNode.next = kv[head];
                }
                else
                {
                    currentNode.next=new Node(head.val);
                    kv.TryAdd(head, currentNode.next);
                }

                if (head.random != null)
                {
                    if (kv.ContainsKey(head.random))
                    {
                        currentNode.next.random = kv[head.random];
                    }
                    else
                    {
                        currentNode.next.random=new Node(head.random.val);
                        kv.TryAdd(head.random, currentNode.next.random);
                    }
                }

                currentNode = currentNode.next;
                head = head.next;
            }

            return tempHead.next.next;
        }
    }
}
/*
 * 使用字典记录已遍历的原链表节点和新链表节点的关系，防止在处理random节点时，重复创建节点，使得节点引用不对
 */
