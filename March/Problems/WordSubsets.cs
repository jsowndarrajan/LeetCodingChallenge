using Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace March.Problems
{
    public class WordSubsets : IProblem
    {
        public string Title => "Word Subsets";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/591/week-4-march-22nd-march-28th/3685/";

        public IList<string> Calculate(string[] A, string[] B)
        {
            var output = new List<string>();

            var bMaps = GetMap(B[0]);
            for (var i = 1; i < B.Length; i++)
            {
                var bMap1 = GetMap(B[i]);
                for (var j = 0; j < 26; j++)
                {
                    bMaps[j] = Math.Max(bMaps[j], bMap1[j]);
                }
            }

            foreach (var word in A)
            {
                var aMap = GetMap(word);
                if (IsSubSet(bMaps, aMap))
                {
                    output.Add(word);
                }
            }

            return output;
        }

        private static bool IsSubSet(int[] bMaps, int[] aMap)
        {
            for (var i = 0; i < 26; i++)
            {
                if (bMaps[i] > aMap[i])
                {
                    return false;
                }
            }
            return true;
        }

        private int[] GetMap(string input)
        {
            var map = new int[26];

            foreach (var @char in input)
            {
                map[@char - 'a'] += 1;
            }

            return map;
        }
    }
}
