using System;
using System.Collections.Generic;

namespace LeetCode.BinarySearchTree
{
    /// <summary>
    /// 703. 数据流中的第K大元素
    /// </summary>
    public class KthLargest
    {
        private int kth;
        private LinkedList<int> nodeList = null;

        public KthLargest(int k, int[] nums)
        {
            kth = k;
            Array.Sort(nums);
            nodeList=new LinkedList<int>(nums);
        }
       
        public int Add(int val)
        {
            if (nodeList.Count == 0||nodeList.First.Value >=val)
            {
                nodeList.AddFirst(val);
            }
            else if (nodeList.Last.Value <= val)
            {
                nodeList.AddLast(val);
            }
            else
            {
                LinkedListNode<int> node = nodeList.First;
                LinkedListNode<int> lastNode = nodeList.Last;
                while (node!=null||lastNode!=null)
                {
                    if (node != null)
                    {
                        if (node.Value >= val)
                        {
                            nodeList.AddBefore(node, new LinkedListNode<int>(val));
                            break;
                        }
                        node = node.Next;
                    }

                    if (lastNode != null)
                    {
                        if (lastNode.Value <= val)
                        {
                            nodeList.AddAfter(lastNode, new LinkedListNode<int>(val));
                            break;
                        }

                        lastNode = lastNode.Previous;
                    }
                }
            }

            //获取kth的值
            LinkedListNode<int> currentNode = nodeList.Last;
            for (int i = 0; i < kth-1; i++)
            {
                currentNode = currentNode.Previous;
            }

            return currentNode.Value;
        }
    }
}