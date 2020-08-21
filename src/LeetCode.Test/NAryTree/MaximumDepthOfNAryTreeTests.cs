using NUnit.Framework;
using LeetCode.NAryTree;
using System.Collections.Generic;

namespace LeetCode.Tests.NAryTree
{
    [TestFixture()]
    public class MaximumDepthOfNAryTreeTests
    {
        [Test()]
        public void MaxDepthTest()
        {
            Node root=new Node(1,new List<Node>(){new Node(3,new List<Node>(){new Node(5),new Node(6)}),new Node(2),new Node(4)});

            int expected = 3;
            int result = new MaximumDepthOfNAryTree().MaxDepth(root);
          
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void MaxDepthTest1()
        {
            Node root = null;

            int expected = 0;
            int result = new MaximumDepthOfNAryTree().MaxDepth(root);
          
            Assert.AreEqual(expected,result);
        }
    }
}
