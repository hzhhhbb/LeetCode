using LeetCode.StringAndArray;
using NUnit.Framework;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class RemoveElementClassTests
    {
        [Test()]
        public void RemoveElementTest()
        {
            int[] nums = {3, 2, 2, 3};
            int val = 3;

            int expected = 2;
            Assert.AreEqual(expected,new RemoveElementClass().RemoveElement(nums,val));
            
        }

        [Test()]
        public void RemoveElementTest1()
        {
            int[] nums = {0,1,2,2,3,0,4,2};
            int val = 2;

            int expected = 5;
            Assert.AreEqual(expected,new RemoveElementClass().RemoveElement(nums,val));
            
        }
    }
}