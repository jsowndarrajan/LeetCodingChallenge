using System.Collections.Generic;
using Shared.Interfaces;

namespace April.Problems
{
    public class DetermineIfStringHalvesAreAlike : IProblem
    {
        public string Title => "Determine if String Halves Are Alike";
        public string Url => "https://leetcode.com/explore/challenge/card/april-leetcoding-challenge-2021/593/week-1-april-1st-april-7th/3699/";

        private readonly HashSet<char> _hashset = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        public bool HalvesAreAlike(string input)
        {
            var mid = input.Length / 2;
            return GetVowelsCount(input, 0, mid) == GetVowelsCount(input, mid, input.Length);
        }

        private int GetVowelsCount(string input, int start, int end)
        {
            var count = 0;
            for (var i = start; i < end; i++)
            {
                if (_hashset.Contains(char.ToLower(input[i])))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
