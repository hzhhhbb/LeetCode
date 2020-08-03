using NUnit.Framework;
using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree
{
    [TestFixture()]
    public class SymmetricTreeTests
    {
        [Test()]
        public void IsSymmetricTest()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            bool expected = true;
            var isSymmetric = new SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.left = new TreeNode(3);

            bool expected = false;
            var isSymmetric = new SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricTest2()
        {
            TreeNode root = null;

            bool expected = true;
            var isSymmetric = new SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricTest3()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);

            bool expected = true;
            var isSymmetric = new SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricTest4()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(3);
            root.right = new TreeNode(2);
            root.right.right = new TreeNode(3);

            bool expected = false;
            var isSymmetric = new SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricOfIterationTest()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            bool expected = true;
            var isSymmetric = new SymmetricTree().IsSymmetricOfIteration(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricOfIterationTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.left = new TreeNode(3);

            bool expected = false;
            var isSymmetric = new SymmetricTree().IsSymmetricOfIteration(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricOfIterationTest2()
        {
            TreeNode root = null;

            bool expected = true;
            var isSymmetric = new SymmetricTree().IsSymmetricOfIteration(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricOfIterationTest3()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);

            bool expected = true;
            var isSymmetric = new SymmetricTree().IsSymmetricOfIteration(root);
            Assert.AreEqual(expected, isSymmetric);
        }

        [Test()]
        public void IsSymmetricOfIterationTest4()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(3);
            root.right = new TreeNode(2);
            root.right.right = new TreeNode(3);

            bool expected = false;
            var isSymmetric = new SymmetricTree().IsSymmetricOfIteration(root);
            Assert.AreEqual(expected, isSymmetric);
        }
    }
}