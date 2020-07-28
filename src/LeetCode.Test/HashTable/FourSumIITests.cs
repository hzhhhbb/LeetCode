﻿using NUnit.Framework;
using LeetCode.HashTable;

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class FourSumIITests
    {
        [Test()]
        public void FourSumCountTest()
        {

            int[] A = {1, 2};
            int[] B = {-2, -1};
            int[] C = {-1, 2};
            int[] D = {0, 2};
            int expected = 2;

            Assert.AreEqual(expected,new FourSumII().FourSumCount(A,B,C,D));
        }
    }
}