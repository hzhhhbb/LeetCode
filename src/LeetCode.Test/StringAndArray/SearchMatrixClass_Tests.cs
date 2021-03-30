using NUnit.Framework;
using LeetCode.StringAndArray;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Shouldly;

namespace LeetCode.Tests.StringAndArray
{
    [TestFixture()]
    public class SearchMatrixClass_Tests
    {
        [Test()]
        [Timeout(1000)]
        public void SearchMatrix_Test()
        {
           int [][] matrix =new int[][]
           {
               new int[]{1,3,5,7,8}, 
               new int[]{10,11,16,20,10}, 
               new int[]{23,30,34,60,70}, 
           };

           new SearchMatrixClass().SearchMatrix(matrix,10).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,11).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,16).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,23).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,60).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,70).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,23).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,1).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,7).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,10).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,3).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,7).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,34).ShouldBeTrue();
           new SearchMatrixClass().SearchMatrix(matrix,35).ShouldBeFalse();
        }
    }
}