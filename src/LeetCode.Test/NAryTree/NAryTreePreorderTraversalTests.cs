using System.Collections.Generic;
using LeetCode.NAryTree;
using NUnit.Framework;

namespace LeetCode.Tests.NAryTree
{
    [TestFixture()]
    public class NAryTreePreorderTraversalTests
    {
        [Test()]
        public void PreorderTest()
        {
            //递归法
            Node root=new Node(1,new List<Node>(){new Node(3,new List<Node>(){new Node(5),new Node(6)}),new Node(2),new Node(4)});
            IList<int> expected=new List<int>(){1,3,5,6,2,4};
            var result = new NAryTreePreorderTraversal().Preorder(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTest1()
        {
            //递归法
            Node root = null;
            IList<int> expected = new List<int>();
            var result = new NAryTreePreorderTraversal().Preorder(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTest2()
        {
            //迭代法
            Node root=new Node(1,new List<Node>(){new Node(3,new List<Node>(){new Node(5),new Node(6)}),new Node(2),new Node(4)});
            IList<int> expected=new List<int>(){1,3,5,6,2,4};
            var result = new NAryTreePreorderTraversal().Preorder1(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void PreorderTest3()
        {
            //迭代法
            Node root = null;
            IList<int> expected = new List<int>();
            var result = new NAryTreePreorderTraversal().Preorder1(root);
            Assert.AreEqual(expected,result);
        }
    }
}