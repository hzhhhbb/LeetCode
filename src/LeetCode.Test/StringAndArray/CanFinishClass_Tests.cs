using NUnit.Framework;
using LeetCode.StringAndArray;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace LeetCode.StringAndArray.Tests
{
    [TestFixture()]
    public class CanFinishClass_Tests
    {
        [Test()]
        public void CanFinish_Test()
        {
            new CanFinishClass().CanFinish(2, new int[][] { new int[]{1,0} }).ShouldBeTrue();
            new CanFinishClass().CanFinish(2, new int[][] { new int[]{1,0},new int[]{0,1} }).ShouldBeFalse();
            int[][] lession = new[]
            {
                new int[]{1,2}, 
                new int[]{2,3}, 
                new int[]{3,4}, 
                new int[]{4,5}, 
                new int[]{0,1}, 
                new int[]{0,2}, 
                new int[]{0,3}, 
                new int[]{0,4}, 
                new int[]{0,5}, 
               
            };
            new CanFinishClass().CanFinish(6, lession).ShouldBeTrue();

        }
    }
}