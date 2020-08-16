using System;
using System.Collections.Generic;
using System.Linq;

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
            if (nodeList.Count == 0)
            {
                nodeList.AddFirst(val);
            }
            else if (nodeList.Last.Value <= val)
            {
                nodeList.AddLast(val);
            }
            else
            {
                // todo优化
                int value = nodeList.First(u => u >= val);
                var node = nodeList.Find(value);
                nodeList.AddBefore(node, new LinkedListNode<int>(val));
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