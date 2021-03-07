using System.Collections.Generic;
using Shared.Interfaces;

namespace March.Problems
{
    public class MyHashMap : IProblem
    {
        public string Title => "Design HashMap";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3663/";

        private const int MaxCount = 10009;
        private readonly List<Element>[] _map;

        public MyHashMap()
        {
            _map = new List<Element>[MaxCount];
        }

        public void Put(int key, int value)
        {
            var hash = GetHash(key);
            var list = _map[hash];

            if (list == null)
            {
                list = new List<Element>();
                _map[hash] = list;
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.Key == key)
                    {
                        item.Value = value;
                        return;
                    }
                }
            }

            list.Add(new Element { Key = key, Value = value });
        }

        public int Get(int key)
        {
            var hash = GetHash(key);
            if (_map[hash] != null)
            {
                foreach (var item in _map[hash])
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }
            }
            return -1;
        }

        public void Remove(int key)
        {
            var hash = GetHash(key);

            if (_map[hash] == null) return;

            for (var i = 0; i < _map[hash].Count; i++)
            {
                if (_map[hash][i].Key == key)
                {
                    _map[hash].RemoveAt(i);
                    break;
                }
            }
        }

        public int GetHash(int key)
        {
            return key % MaxCount;
        }
    }


    class Element
    {
        public int Key { get; set; }
        public int Value { get; set; }
    }
}
