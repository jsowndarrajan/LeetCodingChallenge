using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace March.Problems
{
    public class ReorderedPowerOf2 : IProblem
    {
        public string Title => "Reordered Power of 2";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/590/week-3-march-15th-march-21st/3679/";

        private HashSet<string> Map;

        public ReorderedPowerOf2()
        {
            Init();
        }

        private void Init()
        {
            Map = new HashSet<string>();
            for (var i = 0; i < 32; i++)
            {
                var number = 1 << i;
                Map.Add(SortNumber(number));
            }
        }

        public bool Calculate(int input)
        {
            return Map.Contains(SortNumber(input));
        }

        private string SortNumber(int input)
        {
            var characters = input.ToString().ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
