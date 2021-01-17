using Shared.Helpers;
using System.Diagnostics;
using Shared.Interfaces;

namespace January.Problems
{
    public class CountSortedVowelStrings: IProblem
    {
        public string Title => "Count Sorted Vowel Strings";
        public string Url => "https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/581/week-3-january-15th-january-21st/3607/";

        public string CountVowelStringsByUsingPatternLogic(string input)
        {
            if (int.TryParse(input, out var n))
            {
                return CountVowelStringsByUsingPatternLogic(n).ToString();
            }
            return Messages.InvalidInput;
        }

        /* 
         *       [a,   e,  i,  o,  u]
         * 1 =>  [1,   1,  1,  1,  1]
         * 2 =>  [5,   4,  3,  2,  1]
         * 3 =>  [15, 10,  6,  3,  1]
         */
        public int CountVowelStringsByUsingPatternLogic(int n)
        {
            var result = new[] { 1, 1, 1, 1, 1 };

            for (var i = 1; i < n; i++)
            {
                for (var j = 3; j >= 0; j--)
                {
                    result[j] += result[j + 1];
                }
            }

            var sum = 0;
            for (var i = 0; i < result.Length && n > 0; i++)
            {
                sum += result[i];
            }
            return sum;
        }

        //Time Limit Exceeds
        private int output = 0;
        private readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        public int CountVowelStringsByFormingAllCombinations(int n)
        {
            output = 0;
            CreateVowelString(string.Empty, n);
            return output;
        }

        private void CreateVowelString(string input, int k)
        {
            for (var j = 0; j < vowels.Length; j++)
            {
                if (string.IsNullOrEmpty(input) || input[^1] <= vowels[j])
                {
                    var newString = input + vowels[j];
                    if (newString.Length == k)
                    {
                        output++;
                        Debug.WriteLine(newString);
                    }
                    else
                    {
                        CreateVowelString(newString, k);
                    }
                }
            }
        }
    }
}
