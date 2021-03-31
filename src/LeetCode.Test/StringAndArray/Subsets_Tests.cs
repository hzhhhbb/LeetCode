using NUnit.Framework;
using LeetCode.StringAndArray;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace LeetCode.StringAndArray.Tests
{
    [TestFixture()]
    public class Subsets_Tests
    {
        [Test()]
        public void SubsetsWithDup_Test()
        {

            int[] nums =new int[]{1};
            new Subsets().SubsetsWithDup(nums).Count.ShouldBe(2);

            nums=new int[]{};
            new Subsets().SubsetsWithDup(nums).Count.ShouldBe(1);


            nums = new int[]{1, 2, 3};
            new Subsets().SubsetsWithDup(nums).Count.ShouldBe(8);

            nums = new int[]{1, 2, 2};
            new Subsets().SubsetsWithDup(nums).Count.ShouldBe(6);

            nums = new int[]{1, 2, 2,3};
            new Subsets().SubsetsWithDup(nums).Count.ShouldBe(12);

            nums =  new int[]{1, 2, 3,4,5};
            new Subsets().SubsetsWithDup(nums).Count.ShouldBe(32);
        }
    }
}