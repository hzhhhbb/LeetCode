using NUnit.Framework;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class SerializeAndDeserializeBinaryTreeTests
    {

        [Test()]
        public void serializeTest()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
            root.right=new TreeNode(3);

            string expected = "1,2,3";

            Assert.AreEqual(expected,new SerializeAndDeserializeBinaryTree().serialize(root));
        }

        [Test()]
        public void serializeTest1()
        {
            TreeNode root=new TreeNode(1);
            root.left=new TreeNode(2);
           root.right=new TreeNode(3);
           root.right.left=new TreeNode(4);
           root.right.right=new TreeNode(5);

            string expected = "1,2,3,,,4,5";

            Assert.AreEqual(expected,new SerializeAndDeserializeBinaryTree().serialize(root));
        }

        [Test()]
        public void deserializeTest()
        {
            string input = "1,2,3,,,4,5";

            TreeNode expected=new TreeNode(1);
            expected.left=new TreeNode(2);
            expected.right=new TreeNode(3);
            expected.right.left=new TreeNode(4);
            expected.right.right=new TreeNode(5);

            TreeNode result=new SerializeAndDeserializeBinaryTree().deserialize(input);

            Assert.AreEqual(new BinaryTreePreorderTraversal().PreorderTraversal(result),new BinaryTreePreorderTraversal().PreorderTraversal(expected));

            Assert.AreEqual(new BinaryTreeInorderTraversal().InorderTraversal(expected), new BinaryTreeInorderTraversal().InorderTraversal(result));

        }

        [Test()]
        public void deserializeTest1()
        {
            string input = "";
            TreeNode result=new SerializeAndDeserializeBinaryTree().deserialize(input);
            Assert.AreEqual(null,result);
        }
    }
}