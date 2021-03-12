using Shared.Interfaces;
using System.Collections.Generic;

namespace March.Problems
{
    public class CheckIfAStringContainsAllBinaryCodesOfSizeK : IProblem
    {
        public string Title => "Check If a String Contains All Binary Codes of Size K";
        public string Url => "https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/589/week-2-march-8th-march-14th/3669/";

        public bool HasAllCodes(string input, int k)
        {
            var hashSet = new HashSet<string>();
            for (var i = 0; i <= input.Length - k; i++)
            {
                hashSet.Add(input.Substring(i, k));
            }
            return hashSet.Count == (1 << k);
        }
    }
}
