using System.Collections.Generic;

using LeetCode.HashTable;

using NUnit.Framework;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class FindDuplicateSubtreesClassTests
    {
        [Test()]
        public void FindDuplicateSubtreesTest()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(2);
            root.right.right = new TreeNode(4);
            root.right.left.left = new TreeNode(4);

            List<TreeNode> expected = new List<TreeNode>(2);
            expected.Add(root.left);
            expected.Add(root.left.left);

            var result = new FindDuplicateSubtreesClass().FindDuplicateSubtrees(root);
            if (expected.Count != result.Count)
            {
                Assert.Fail();
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (!expected[i].IsEqual(result[i]))
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }
    }
}