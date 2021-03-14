using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace March.Problems
{
    public class BinaryTreesWithFactors : IProblem
    {
        public string Title => "Binary Trees With Factors";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3670/";

        private const int Mod = 1000000007;
        public int NumFactoredBinaryTrees(int[] input)
        {
            Array.Sort(input);
            var map = new Dictionary<int, long>();
            long output = 0;
            for (var i = 0; i < input.Length; i++)
            {
                long init = 1;
                var root = input[i];
                for (var j = 0; j < i; j++)
                {
                    var num1 = input[j];
                    if (root % num1 == 0)
                    {
                        var num2 = root / num1;
                        if (map.ContainsKey(num2))
                        {
                            init = (init + (map[num1] * map[num2]) % Mod) % Mod;
                        }
                    }
                }
                map.Add(root, init);
                output = (output + init) % Mod;
            }
            return (int)output;
        }
    }
}   
