using System;
using System.Collections.Generic;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 380. 常数时间插入、删除和获取随机元素
    /// </summary>
    public class RandomizedSet
    {
        private List<int> _container;

        private Dictionary<int, int> _valueAndIndexes;

        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            _container = new List<int>();
            _valueAndIndexes = new Dictionary<int, int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (!_valueAndIndexes.ContainsKey(val))
            {
                _container.Add(val);
                _valueAndIndexes.Add(val, _container.Count - 1);
                return true;
            }

            return false;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (_valueAndIndexes.ContainsKey(val))
            {
                if (_container.Count != 1)
                {
                    int valueIndex = _valueAndIndexes[val];

                    _container[valueIndex] = _container[valueIndex] ^ _container[_container.Count - 1];
                    _container[_container.Count - 1] = _container[valueIndex] ^ _container[_container.Count - 1];
                    _container[valueIndex] = _container[valueIndex] ^ _container[_container.Count - 1];

                    _valueAndIndexes[_container[valueIndex]] = valueIndex;

                    _container.RemoveAt(_container.Count - 1);
                    _valueAndIndexes.Remove(val);
                }
                else
                {
                    _container.RemoveAt(_container.Count - 1);
                    _valueAndIndexes.Remove(val);
                }

                return true;
            }

            return false;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return this._container[new Random().Next(0, _container.Count)];
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