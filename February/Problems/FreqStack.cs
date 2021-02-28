using System.Collections.Generic;
using Shared.Interfaces;

namespace February.Problems
{
    public class FreqStack : IProblem
    {
        public string Title => "Maximum Frequency Stack";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/587/week-4-february-22nd-february-28th/3655/";
        
        private readonly Dictionary<int, int> _map;
        private readonly Dictionary<int, Stack<int>> _stack;

        public FreqStack()
        {
            _map = new Dictionary<int, int>();
            _stack = new Dictionary<int, Stack<int>>();
        }

        public void Push(int x)
        {
            if (_map.ContainsKey(x))
            {
                _map[x] += 1;
            }
            else
            {
                _map.Add(x, 1);
            }

            var partitionKey = _map[x];

            if (_stack.ContainsKey(partitionKey))
            {
                _stack[partitionKey].Push(x);
            }
            else
            {
                _stack[partitionKey] = new Stack<int>();
                _stack[partitionKey].Push(x);
            }
        }

        public int Pop()
        {
            var lastPartitionIndex = _stack.Count;

            var item = _stack[lastPartitionIndex].Pop();
            _map[item] -= 1;

            if (_stack[lastPartitionIndex].Count == 0)
            {
                _stack.Remove(lastPartitionIndex);
            }

            return item;
        }
    }
}
