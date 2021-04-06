using NUnit.Framework;
using LeetCode.StringAndArray;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace LeetCode.StringAndArray.Tests
{
    [TestFixture()]
    public class RemoveDuplicatesClass_Tests
    {
        [Test()]
        [Timeout(1000)]
        public void RemoveDuplicates_Test()
        {
            int[] nums = {1, 1, 1, 2, 2, 3};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(5);

            nums =new int[]{0,0,1,1,1,1,2,3,3};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(7);


            nums =new int[]{0,0,1,1,1,1,1,1,1,1};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(4);

            nums =new int[]{0,0,0};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(2);

            nums =new int[]{0,0};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(2);

            nums =new int[]{0,0,0,0,1,1,1,3,3,3};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(6);

            nums =new int[]{1,2,3,4,5,6,7,8,9};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(9);

            nums =new int[]{1,1,3,3,5,5,5,7,9};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(8);

            nums =new int[]{1};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(1);

            nums =new int[]{1,1};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(2);

            nums =new int[]{};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(0);

            nums =new int[]{1,2,2,2};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(3);

            nums =new int[]{1,2,2,3};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(4);

            nums =new int[]{1,1,2,2,3,4,5,6,7,8,9,9,9,9,9,9,9,9};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(12);

            nums =new int[]{1,2,2,2,3};
            new RemoveDuplicatesClass().RemoveDuplicates(nums).ShouldBe(4);
        }

    }
}