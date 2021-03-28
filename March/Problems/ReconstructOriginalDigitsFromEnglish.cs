using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace March.Problems
{
    public class ReconstructOriginalDigitsFromEnglish : IProblem
    {
        public string Title => "Reconstruct Original Digits from English";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/591/week-4-march-22nd-march-28th/3687/";
        
        private readonly string[] _numbers = new[]
        {
           "zero",
           "one",
           "two",
           "three",
           "four",
           "five",
           "six",
           "seven",
           "eight",
           "nine",
        };

        class Pair
        {
            public char Char { get; set; }

            public int Number { get; set; }
        }

        private readonly Pair[] _uniqueOrder = {
            new Pair { Char = 'z', Number = 0},
            new Pair { Char = 'w', Number = 2},
            new Pair { Char = 'x', Number = 6},
            new Pair { Char = 'u', Number = 4},
            new Pair { Char = 'g', Number = 8},
            new Pair { Char = 's', Number = 7},
            new Pair { Char = 'o', Number = 1},
            new Pair { Char = 'h', Number = 3},
            new Pair { Char = 'f', Number = 5},
            new Pair { Char = 'i', Number = 9},
        };

        public string OriginalDigits(string input)
        {
            var map = new int[26];
            var result = new int[10];

            foreach (var @char in input)
            {
                map[@char - 'a'] += 1;
            }

            foreach (var order in _uniqueOrder)
            {
                var characterCount = map[order.Char - 'a'];
                if (characterCount > 0)
                {
                    result[order.Number] = characterCount;

                    foreach (var @char in _numbers[order.Number])
                    {
                        map[@char - 'a'] -= characterCount;
                    }
                }
            }

            var output = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
            {
                for (var j = 0; j < result[i]; j++)
                {
                    output.Append(i);
                }
            }
            return output.ToString();
        }
    }
}
