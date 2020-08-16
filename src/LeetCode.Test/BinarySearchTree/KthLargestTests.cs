using NUnit.Framework;
using LeetCode.BinarySearchTree;

namespace LeetCode.Tests.BinarySearchTree
{
    [TestFixture()]
    public class KthLargestTests
    {
        [Test()]
        public void KthLargestTest()
        {
            int k = 3;
            int[] nums = {4, 5, 8, 2};
            KthLargest kthLargest = new KthLargest(k, nums);
        }

        [Test()]
        public void AddTest()
        {
            int k = 3;
            int[] arr = {4,5,8,2};
            KthLargest kthLargest = new KthLargest(k, arr);
           Assert.IsTrue(kthLargest.Add(3)==4);   // returns 4
           Assert.IsTrue(kthLargest.Add(5)==5);   // returns 5
           Assert.IsTrue(kthLargest.Add(10)==5);  // returns 5
           Assert.IsTrue(kthLargest.Add(9)==8);   // returns 8
           Assert.IsTrue(kthLargest.Add(4)==8);   // returns 8
        }
    }
}