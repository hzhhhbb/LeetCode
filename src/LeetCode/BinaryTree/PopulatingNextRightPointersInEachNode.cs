namespace LeetCode.BinaryTree
{
    /// <summary>
    /// 116. 填充每个节点的下一个右侧节点指针
    /// </summary>
    public class PopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            this.Connect(root.left, root.right);
            return root;
        }

        private void Connect(Node left, Node right)
        {
            if (left != null)
            {
                left.next = right;
                this.Connect(left.left, left.right);
                this.Connect(left.right, right.left);
            }

            if (right != null)
            {
                this.Connect(right.left, right.right);
            }
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
