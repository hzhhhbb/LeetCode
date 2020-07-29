﻿using NUnit.Framework;
using LeetCode.HashTable;

namespace LeetCode.Tests.HashTable
{
    [TestFixture()]
    public class RandomizedSetTests
    {
        [Test()]
        public void RandomizedSetTest()
        {
            RandomizedSet set=new RandomizedSet();
            Assert.IsTrue(set.Insert(1));
            Assert.IsTrue(set.Insert(2));
            Assert.IsTrue(set.Insert(3));
            Assert.IsFalse(set.Insert(3));
            Assert.IsFalse(set.Remove(4));
            Assert.IsTrue(set.Remove(3));
            Assert.IsTrue(set.GetRandom()==1||set.GetRandom()==2);

        }

        [Test()]
        public void RandomizedSetTest1()
        {
            RandomizedSet set=new RandomizedSet();
            Assert.IsTrue(set.Insert(3));
            Assert.IsTrue(set.Remove(3));
            Assert.IsFalse(set.Remove(0));
            Assert.IsTrue(set.Insert(3));
            Assert.IsTrue(set.GetRandom()==3);
            Assert.IsFalse(set.Remove(0));
        }
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */