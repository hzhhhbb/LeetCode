using NUnit.Framework;
using LeetCode.BinaryTree;
using System.Linq;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class ConstructBinaryTreeFromPreorderAndInorderTraversalTests
    {
        [Test()]
        public void BuildTreeTest()
        {
            int[] preorder = {3, 9, 20, 15, 7};
            int[] inorder = {9, 3, 15, 20, 7};
            
            var tree=new ConstructBinaryTreeFromPreorderAndInorderTraversal().BuildTree(preorder,inorder);

            Assert.AreEqual(preorder,new BinaryTreePreorderTraversal().PreorderTraversal(tree).ToArray());
            Assert.AreEqual(inorder,new BinaryTreeInorderTraversal().InorderTraversal(tree).ToArray());
        }
    }
}