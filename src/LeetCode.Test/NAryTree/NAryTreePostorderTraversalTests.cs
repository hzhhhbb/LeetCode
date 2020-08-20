using System.Collections.Generic;
using LeetCode.NAryTree;
using NUnit.Framework;

namespace LeetCode.Tests.NAryTree
{
    [TestFixture()]
    public class NAryTreePostorderTraversalTests
    {
        [Test()]
        public void PostorderTest()
        {
            //递归法
            Node root=new Node(1,new List<Node>(){new Node(3,new List<Node>(){new Node(5),new Node(6)}),new Node(2),new Node(4)});
            IList<int> expected=new List<int>(){5,6,3,2,4,1};
            var result = new NAryTreePostorderTraversal().Postorder(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void Postorder1Test()
        {
            //迭代法
            Node root=new Node(1,new List<Node>(){new Node(3,new List<Node>(){new Node(5),new Node(6)}),new Node(2),new Node(4)});
            IList<int> expected=new List<int>(){5,6,3,2,4,1};
            var result = new NAryTreePostorderTraversal().Postorder1(root);
            Assert.AreEqual(expected,result);
        }
    }
}