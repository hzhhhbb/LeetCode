using NUnit.Framework;
using LeetCode.BinaryTree;
using System.Linq;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class ConstructBinaryTreeFromInorderAndPostorderTraversalTests
    {
        [Test()]
        public void BuildTreeTest()
        {
            int[] postorder = {9,15,7,20,3};
            int[] inorder = {9,3,15,20,7};
            
            var tree=new ConstructBinaryTreeFromInorderAndPostorderTraversal().BuildTree(inorder,postorder);

            Assert.AreEqual(postorder,new BinaryTreePostorderTraversal().PostorderTraversal(tree).ToArray());
            Assert.AreEqual(inorder,new BinaryTreeInorderTraversal().InorderTraversal(tree).ToArray());
        }
    }
}