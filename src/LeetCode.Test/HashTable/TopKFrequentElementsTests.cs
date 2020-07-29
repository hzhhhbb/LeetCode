using NUnit.Framework;
using LeetCode.HashTable;
using System.Linq;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class TopKFrequentElementsTests
    {
        [Test()]
        public void TopKFrequentTest()
        {
            int[] nums = {1, 1, 1, 2, 2, 3};
            int k = 2;
            int[] expected = {1, 2};
            for (int i = 0; i < expected.Length; i++)
            {
                var result=new TopKFrequentElements().TopKFrequent(nums,k);
                if (!result.Contains(expected[i]))
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }

        [Test()]
        public void TopKFrequentTest1()
        {
            int[] nums = {1};
            int k = 1;
            int[] expected = {1};
            for (int i = 0; i < expected.Length; i++)
            {
                var result=new TopKFrequentElements().TopKFrequent(nums,k);
                if (!result.Contains(expected[i]))
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }

        [Test()]
        public void TopKFrequentTest2()
        {
            int[] nums = {1,2};
            int k = 2;
            int[] expected = {1,2};
            for (int i = 0; i < expected.Length; i++)
            {
                var result=new TopKFrequentElements().TopKFrequent(nums,k);
                if (!result.Contains(expected[i]))
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }
    }
}