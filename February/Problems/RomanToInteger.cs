using Shared.Interfaces;
using System.Collections.Generic;

namespace February.Problems
{
    public class RomanToInteger : IProblem
    {
        public string Title => "Roman to Integer";
        public string Url => "https://leetcode.com/explore/challenge/card/february-leetcoding-challenge-2021/586/week-3-february-15th-february-21st/3646/";

        private readonly Dictionary<char, int> _map = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int RomanToInt(string input)
        {
            var output = 0;

            for (var i = 0; i < input.Length - 1; i++)
            {
                if (_map[input[i]] < _map[input[i + 1]])
                {
                    output -= _map[input[i]];
                }
                else
                {
                    output += _map[input[i]];
                }
            }

            return output + _map[input[^1]];
        }
    }
}
