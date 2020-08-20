using NUnit.Framework;
using LeetCode.NAryTree;
using System.Collections.Generic;

namespace LeetCode.Tests.NAryTree
{
    [TestFixture()]
    public class NAryTreeLevelOrderTraversalTests
    {
        [Test()]
        public void LevelOrderTest()
        {
            Node root=new Node(1,new List<Node>(){new Node(3,new List<Node>(){new Node(5),new Node(6)}),new Node(2),new Node(4)});
            IList<IList<int>> expected=new List<IList<int>>()
            {
                new List<int>(){1},
                new List<int>(){3,2,4},
                new List<int>(){5,6},
            };

            var result = new NAryTreeLevelOrderTraversal().LevelOrder(root);
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LevelOrderTest1()
        {
            Node root=new Node(1,new List<Node>(){new Node(3),new Node(2,new List<Node>(){new Node(5),new Node(6)}),new Node(4)});
            IList<IList<int>> expected=new List<IList<int>>()
            {
                new List<int>(){1},
                new List<int>(){3,2,4},
                new List<int>(){5,6},
            };

            var result = new NAryTreeLevelOrderTraversal().LevelOrder(root);
            Assert.AreEqual(expected,result);
        }
    }
}