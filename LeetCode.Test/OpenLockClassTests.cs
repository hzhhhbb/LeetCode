using NUnit.Framework;
using LeetCode;

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class OpenLockClassTests
    {
        [Test()]
        public void OpenLockTest()
        {
            string[] deadends={"8887","8889","8878","8898","8788","8988","7888","9888"};
            string target = "8888";
            Console.WriteLine(new OpenLockClass().OpenLock(deadends,target));//-1

            //不能打开的情况
            Assert.AreEqual(-1,new OpenLockClass().OpenLock(deadends,target));
        }

        [Test()]
        public void OpenLockTest1()
        {
            string[] deadend={"0201","0101","0102","1212","2002"};
            string target1 = "0202";

            //正常打开的情况
            Assert.AreEqual(6,new OpenLockClass().OpenLock(deadend,target1));
        }
    }
}